using System.Collections.Generic;
using UnityEngine;

namespace StrategyGame_2DPlatformer.Core
{
    public interface IPlaceable
    {
        bool IsPlaceable { get; set; }
        int SizeX { get; set; }
        int SizeY { get; set; }
        bool IsPlaced { get; set; }
        List<Vector3Int> OccupiedPositions { get; set; }
        void OnBuildingPlaced();
    }
}
