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
    private GameObject _button;

    public void SpawnButton()
    {
        _button = new GameObject("Restart");
        _button.transform.SetParent(_holder);
        _button.transform.localPosition = Vector2.zero;
        _button.AddComponent<Image>().sprite = _buttonSprite;
        _button.AddComponent<Button>().onClick = _onClickEvent;
    }

    public void DestroyButton()
    {
        Destroy(_button.gameObject);
    }
}
