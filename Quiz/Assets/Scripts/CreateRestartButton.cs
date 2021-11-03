using UnityEngine;
using UnityEngine.UI;

public class CreateRestartButton : MonoBehaviour
{
    [SerializeField]
    private Sprite _buttonSprite;
    [SerializeField]
    private Transform _holder;
    [SerializeField]
    private Button.ButtonClickedEvent _onClickEvent;

    private GameObject button;

    public void SpawnButton()
    {
        button = new GameObject("Restart");
        button.transform.SetParent(_holder);
        button.transform.localPosition = Vector2.zero;
        button.AddComponent<Image>().sprite = _buttonSprite;
        button.AddComponent<Button>().onClick = _onClickEvent;
    }
    
    public void DestroyButton()
    {
        Destroy(button.gameObject);
    }
}
