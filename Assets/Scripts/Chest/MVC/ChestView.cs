using UnityEngine;
using UnityEngine.UI;

namespace ChestSystem
{
    public class ChestView : MonoBehaviour
    {
        [SerializeField] private Image image;

        public void SetSprite(Sprite sprite){
            image.sprite = sprite;
        }
    }
}
