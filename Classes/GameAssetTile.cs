using System;
using System.Collections.Generic;
using System.Text;

namespace LevelBuilderManager.Classes
{
    public class GameAssetTile : GameAsset
    {
        private string tileCategory;
        private bool canBeWalkedOn;

        public string TileCategory
        {
            get { return tileCategory; }
            set { tileCategory = value; }
        }

        public bool CanBeWalkedOn
        {
            get { return canBeWalkedOn; }
            set { canBeWalkedOn = value; }
        }

        public GameAssetTile(string AssetID, string AssetName, string TileCategory, bool CanBeWalkedOn) : base(AssetID, AssetName)
        {
            tileCategory = TileCategory;
            canBeWalkedOn = CanBeWalkedOn;
        }
    }
}
