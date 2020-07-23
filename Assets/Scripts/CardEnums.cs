using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.CrystalBright 
{
    public class CardEnums : MonoBehaviour
    {
        public enum CardType { None, Martial, Magic, Creature }
        public enum ScoreConditionType { None, Score, Required, Restricted }
        public enum ScoreConditionDirection { TopLeft, Top, TopRight, Left, Right, BottomLeft, Bottom, BottomRight }
        public enum ScoreConditionDistance { Self, One, Two, Both }
    }
}