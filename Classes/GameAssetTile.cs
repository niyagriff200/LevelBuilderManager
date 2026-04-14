using System;
using System.Collections.Generic;
using System.Text;

namespace LevelBuilderManager.Classes
{
    public class GameAssetTile : GameAsset
    {
        private string tileType;
        private bool canBeWalkedOn;

        public string TileType
        {
            get { return tileType; }
            set { tileType = value; }
        }

        public bool CanBeWalkedOn
        {
            get { return canBeWalkedOn; }
            set { canBeWalkedOn = value; }
        }

        public GameAssetTile(string AssetID, string AssetName, string TileType, bool CanBeWalkedOn) : base(AssetID, AssetName)
        {
            tileType = TileType;
            canBeWalkedOn = CanBeWalkedOn;
        }
    }
}
