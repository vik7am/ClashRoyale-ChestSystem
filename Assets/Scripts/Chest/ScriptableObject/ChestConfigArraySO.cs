using UnityEngine;

namespace ChestSystem
{
    [CreateAssetMenu(fileName ="ChestConfigArraySO", menuName = "ScriptableObject/ChestConfigArraySO")]
    public class ChestConfigArraySO : ScriptableObject
    {
        public ChestConfigSO[] chestConfigArray;
    }
}
