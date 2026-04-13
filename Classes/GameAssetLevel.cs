using System;
using System.Collections.Generic;
using System.Text;

namespace LevelBuilderManager.Classes
{
    public class GameAssetLevel : GameAsset
    {
        private string levelDifficulty;
        private string levelTheme;

        public string LevelDifficulty
        {
            get { return levelDifficulty; }
            set { levelDifficulty = value; }
        }

        public string LevelTheme
        {
            get { return levelTheme; }
            set { levelTheme = value; }
        }


        public GameAssetLevel(string AssetID, string AssetName, string LevelDifficulty, string LevelTheme) : base(AssetID, AssetName)
        {
            levelDifficulty = LevelDifficulty;
            levelTheme = LevelTheme;

        }
    }
}
