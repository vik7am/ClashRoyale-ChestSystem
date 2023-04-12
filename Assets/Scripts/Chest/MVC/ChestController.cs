using UnityEngine;

namespace ChestSystem
{
    public class ChestController
    {
        private ChestView _chestView;
        private ChestModel _chestModel;

        public ChestController(ChestView chestView, ChestModel chestModel, Transform position){
            _chestView = GameObject.Instantiate<ChestView>(chestView, position);
            _chestView.transform.localScale = Vector3.one;
            _chestModel = chestModel;
            _chestView.SetSprite(_chestModel.sprite);
        }

        public void SetChestParentTransform(Transform parent){
            _chestView.transform.SetParent(parent);
        }
    }
}
