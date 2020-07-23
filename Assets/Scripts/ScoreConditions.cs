using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.CrystalBright 
{
    public enum CardType { None, Martial, Magic, Creature, Any }
    public enum ScoreConditionType { None, Score, Required, Restricted }
    public enum ScoreConditionDirection { TopLeft, Top, TopRight, Left, Right, BottomLeft, Bottom, BottomRight }
    public enum ScoreConditionDistance { Self, One, Two, Both }
    public enum CardRewardType { OneRed, OneGreen, OneBlue }

  
    [CreateAssetMenu(fileName = "New Score Condition", menuName = "CrystalBright/Score Conditions", order = 1)]
    public class ScoreConditions : ScriptableObject 
    {
        public ScoreConditionType scoreConditionType;
        public ScoreConditionDirection scoreConditionDirection;
        public ScoreConditionDistance scoreConditionDistance;
        public CardType cardType;
    }
}