using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChestSystem
{
    public class ChestSlotController : MonoBehaviour
    {
        private bool slotEmpty;
        ChestController chestController;
        public ChestView chestView;
        public ChestModel chestModel;

        private void Start() {
            slotEmpty = true;
        }

        public bool IsSlotEmpty(){
            return slotEmpty;
        }
        public void SpawnChest(){
            chestModel = new ChestModel();
            chestController = new ChestController(chestView, chestModel, transform);
            chestController.SetChestParentTransform(transform);
            slotEmpty = false;
        }
    }
}
