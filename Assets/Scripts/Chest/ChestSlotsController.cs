using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem
{
    public class ChestSlotsController : MonoBehaviour
    {
        public ChestSlotController[] chestSlotControllers;
        private int chestSlotsUsed;
        private int totalChestSlots;

        private void Start() {
            chestSlotsUsed = 0;
            totalChestSlots = 4;
        }

        public bool emptySlotsAvailable(){
            return chestSlotsUsed < totalChestSlots;
        }

        public void SpawnChest(){
            GetEmptyChestSlot().SpawnChest();
            chestSlotsUsed++;
        }

        public ChestSlotController GetEmptyChestSlot(){
            for(int i=0; i<chestSlotControllers.Length; i++){
                if(chestSlotControllers[i].IsSlotEmpty()){
                    return chestSlotControllers[i];
                }
            }
            return null;
        }
    }
}
