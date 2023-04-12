using UnityEngine;

namespace ChestSystem
{
    public class ChestService : GenericMonoSingleton<ChestService>
    {
        public ChestInventoryController chestSlotsController;

        public void SpawnChest(){
            if(chestSlotsController.EmptySlotsAvailable()){
                chestSlotsController.SpawnChest();
            }
            else
                Debug.Log("Chest Slot is Full!");
        }
    }
}
