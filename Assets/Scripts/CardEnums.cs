using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.CrystalBright 
{
    public class CardEnums : MonoBehaviour
    {
        public enum CardType { None, Martial, Magic, Creature }
        public enum ScoreConditionType { None, Score, Required, Restricted }
    }
}