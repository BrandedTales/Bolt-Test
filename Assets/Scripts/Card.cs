using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.CrystalBright 
{
    [CreateAssetMenu(fileName = "Card", menuName="CrystalBright/New Card", order = 1)]
    public class Card : ScriptableObject
    {
        public Sprite cardImage;
        public CardType cardType;
        public CardRewardType cardRewardType;

        public ScoreConditions[] scoreConditions;
        
    }
}