using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace Kosev.Game
{
    public struct goldCoinProperties : IComponentData
    {
        public float2 FieldDimensions;
        public int NumberofCoins;
        public Entity CoinPrefab;
    }
}