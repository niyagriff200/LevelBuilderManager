using System;
using System.Collections.Generic;
using System.Text;

namespace LevelBuilderManager.Classes
{
    public class GameAssetTile : GameAsset
    {
        public string Type { get; set; }
        public bool CanBeWalkedOn { get; set; } = true;

        public GameAssetTile(int AssetID, string AssetName, string TileType, bool TileCanBeWalkedOn) : base(AssetID, AssetName)
        {
            Type = TileType;
            CanBeWalkedOn = TileCanBeWalkedOn;
        }
    }
}
