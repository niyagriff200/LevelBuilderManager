using System;
using System.Collections.Generic;
using System.Text;

namespace LevelBuilderManager.Classes
{
    public class GameAsset
    {
        private int assetID;
        private string assetName;
        

        public int AssetID
        {
            get { return assetID; }
            set { assetID = value; }
        }

        public string AssetName
        {
            get { return assetName; }
            set { assetName = value; }
        }

        public GameAsset(int AssetID, string AssetName)
        {
            this.assetID = AssetID;
            this.assetName = AssetName;
        }
    }
}
