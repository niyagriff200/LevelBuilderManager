using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace LevelBuilderManager.ML
{
    public class MLLevelData
    {
        // These properties represent the features of the level that will be used for prediction.
        // They are decorated with the [LoadColumn] attribute to specify which column in the input data they correspond to.
        [LoadColumn(0)]
        public float NumEnemies { get; set; }

        [LoadColumn(1)]
        public float NumObstacles { get; set; }

        [LoadColumn(2)]
        public float LevelDifficulty { get; set; }
    }
        // Represents the predicted difficulty returned by the ML model
    public class MLLevelPrediction
    {
        // ML.NET outputs predictions in a column named "Score"
        [ColumnName("Score")]
        public float PredictedDifficulty { get; set; }
    }


    public class MLLevel
    {
        private readonly MLContext _mlContext;
        private PredictionEngine<MLLevelData, MLLevelPrediction> _engine;

        // Indicates whether the model is trained and ready
        public bool IsReady => _engine != null;

        public MLLevel()
        {
            _mlContext = new MLContext(seed: 42);
        }

        // The path to the CSV file containing the training data. This file should have columns for NumEnemies, NumObstacles, and LevelDifficulty.
        private const string DataPath = "MLLevelData.csv";

        // Trains the model using a CSV file
        public (double rSquared, double mae) Train()
        {
            
            // Load CSV into IDataView
            IDataView dataView = _mlContext.Data.LoadFromTextFile<MLLevelData>(
                path: DataPath,
                hasHeader: true,
                separatorChar: ','
            );

            // Build the ML pipeline
            var pipeline = _mlContext.Transforms
                .Concatenate("Features",
                    nameof(MLLevelData.NumEnemies),
                    nameof(MLLevelData.NumObstacles)
                )
                .Append(_mlContext.Regression.Trainers.Sdca(
                    labelColumnName: nameof(MLLevelData.LevelDifficulty),
                    featureColumnName: "Features"
                ));

            // Train the model
            var model = pipeline.Fit(dataView);

            // Create prediction engine
            _engine = _mlContext.Model.CreatePredictionEngine<MLLevelData, MLLevelPrediction>(model);

            // Evaluate model accuracy
            var predictions = model.Transform(dataView);
            var metrics = _mlContext.Regression.Evaluate(
                predictions,
                labelColumnName: nameof(MLLevelData.LevelDifficulty)
            );

            return (metrics.RSquared, metrics.MeanAbsoluteError);
        }

        // Predicts difficulty for a new level
        public float Predict(float enemies, float obstacles)
        {
            if (!IsReady)
                throw new InvalidOperationException("Model not trained.");

            var input = new MLLevelData
            {
                NumEnemies = enemies,
                NumObstacles = obstacles
            };

            return _engine.Predict(input).PredictedDifficulty;
        }
    }
}


