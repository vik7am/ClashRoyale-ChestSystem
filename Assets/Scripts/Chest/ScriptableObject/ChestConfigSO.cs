using UnityEngine;

namespace ChestSystem
{
    [CreateAssetMenu(fileName = "ChestConfigSO", menuName = "ScriptableObject/ChestConfigSO")]
    public class ChestConfigSO : ScriptableObject
    {
        public ChestType chestType;
        public Sprite sprite;
        public int unlockDuration;
        public int minGems;
        public int maxGems;
        public int minCoins;
        public int maxCoins; 
    }
}
