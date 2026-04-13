using System;
using System.Collections.Generic;
using System.Text;

namespace LevelBuilderManager.Classes
{
    public class GameAsset
    {
        private string assetID;
        private string assetName;
        

        public string AssetID
        {
            get { return assetID; }
            set { assetID = value; }
        }

        public string AssetName
        {
            get { return assetName; }
            set { assetName = value; }
        }

        public GameAsset(string AssetID, string AssetName)
        {
            assetID = AssetID;
            assetName = AssetName;
        }
    }
}
