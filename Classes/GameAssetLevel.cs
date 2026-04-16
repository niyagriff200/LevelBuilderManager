using System;
using System.Collections.Generic;
using System.Text;

namespace LevelBuilderManager.Classes
{
    public class GameAssetLevel : GameAsset
    {
        public string Theme { get; set; }
        public int Difficulty { get; set; }
        public int EnemyCount { get; set; }


        public GameAssetLevel(int AssetID, string AssetName, int LevelDifficulty, string LevelTheme, int LevelEnemyCount) : base(AssetID, AssetName)
        {
            Difficulty = LevelDifficulty;
            Theme = LevelTheme;
            this.EnemyCount = LevelEnemyCount;
        }
    }
}
