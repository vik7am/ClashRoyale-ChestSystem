using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem
{
    public class ChestService : GenericMonoSingleton<ChestService>
    {
        public ChestSlotsController chestSlotsController;

        public void SpawnChest(){
            if(chestSlotsController.emptySlotsAvailable()){
                chestSlotsController.SpawnChest();
            }
            else
                Debug.Log("Chest Slot is Full!");
        }
    }
}
