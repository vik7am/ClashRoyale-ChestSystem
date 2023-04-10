using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ChestSystem
{
    public class ChestSpawner : MonoBehaviour
    {
        public Button button;
        void Start()
        {
            button.onClick.AddListener(SpawnChest);
        }

        private void SpawnChest(){
            ChestService.Instance.SpawnChest();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
