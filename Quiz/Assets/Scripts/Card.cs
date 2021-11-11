using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public void SetSprite(Sprite sprite)
    {
        base.GetComponent<Image>().sprite = sprite;
        base.GetComponent<Image>().SetNativeSize();
    }
}
