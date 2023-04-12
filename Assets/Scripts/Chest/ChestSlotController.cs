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
        public void SpawnChest(ChestConfigArraySO chestConfigArraySO){
            int randomChestNo = Random.Range(0, 4);
            ChestConfigSO chestConfig = chestConfigArraySO.chestConfigArray[randomChestNo];
            chestModel = new ChestModel(chestConfig);
            chestController = new ChestController(chestView, chestModel, transform);
            chestController.SetChestParentTransform(transform);
            slotEmpty = false;
        }
    }
}
