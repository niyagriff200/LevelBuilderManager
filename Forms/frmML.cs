using LevelBuilderManager.ML;

namespace LevelBuilderManager.Forms
{
    public partial class frmML : Form
    {
        //So I can return to the main menu when I close this form
        private frmMainMenu frmOriginal;
        private MLLevel _ml = new MLLevel();


        public frmML()
        {
            InitializeComponent();
        }

        public frmML(frmMainMenu mainMenuObj)
        {
            InitializeComponent();
            frmOriginal = mainMenuObj;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            //When the return button is clicked, close this form (which will trigger the FormClosed event and show the main menu)
            frmOriginal.Show();
            this.Close();
        }

        private void frmML_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the form is closing, show the main menu again
            frmOriginal.Show();
        }

        private void btnTrainModel_Click(object sender, EventArgs e)
        {
            try
            {
                // Train the model using your CSV file
                var result = _ml.Train();

                // Show training results
                lbMessage.Text = $"Model trained!\nR\u00B2: {result.rSquared:0.00}\nMAE: {result.mae:0.00}";
            }
            catch (Exception ex)
            {
                lbMessage.Text = "Training failed: " + ex.Message;
            }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_ml.IsReady)
                {
                    lbMessage.Text = "Train the model first.";
                    return;
                }

                float enemies = (float)numEnemies.Value;
                float obstacles = (float)numObstacles.Value;

                float prediction = _ml.Predict(enemies, obstacles);

                lbMessage.Text = $"Predicted Difficulty: {prediction}";
            }
            catch (Exception ex)
            {
                lbMessage.Text = "Prediction failed: " + ex.Message;
            }
        }

    }
}
