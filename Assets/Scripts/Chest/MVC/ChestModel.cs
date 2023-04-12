using UnityEngine;

namespace ChestSystem
{
    public class ChestModel
    {
        public ChestType chestType;
        public Sprite sprite;
        public int unlockDuration;
        public int minGems;
        public int maxGems;
        public int minCoins;
        public int maxCoins; 
        
        public ChestModel(ChestConfigSO chestConfigSO){
            chestType = chestConfigSO.chestType;
            sprite = chestConfigSO.sprite;
            unlockDuration = chestConfigSO.unlockDuration;
            minGems = chestConfigSO.minGems;
            maxGems = chestConfigSO.maxGems;
            minCoins = chestConfigSO.minCoins;
            maxCoins = chestConfigSO.maxCoins;
        }
    }
}
