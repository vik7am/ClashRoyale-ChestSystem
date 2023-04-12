using UnityEngine;

namespace ChestSystem
{
    public class ChestInventoryController : MonoBehaviour
    {
        [SerializeField] private ChestSlotController[] chestSlotControllers;
        [SerializeField] private ChestConfigArraySO chestConfigArraySO;
        private int chestSlotsUsed;
        private int totalChestSlots;

        private void Start() {
            chestSlotsUsed = 0;
            totalChestSlots = 4;
        }

        public bool EmptySlotsAvailable(){
            return chestSlotsUsed < totalChestSlots;
        }

        public void SpawnChest(){
            GetEmptyChestSlot().SpawnChest(chestConfigArraySO);
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
