using UnityEngine;
using UnityEngine.UI;

namespace ChestSystem
{
    public class ChestSpawner : MonoBehaviour
    {
        [SerializeField] private Button button;

        void Start(){
            button.onClick.AddListener(SpawnChest);
        }

        private void SpawnChest(){
            ChestService.Instance.SpawnChest();
        }
    }
}
