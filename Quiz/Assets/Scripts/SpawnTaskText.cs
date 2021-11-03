using UnityEngine;
using UnityEngine.UI;
public class SpawnTaskText : MonoBehaviour
{
    [SerializeField]
    private string _findText;

    [SerializeField]
    private Transform _holder;

    private Text _taskText;

    [SerializeField]
    private Vector2 _textPosition;

    [SerializeField]
    private Font _font;

    private GameObject _text_gameObject;

    private string _answerText;

    public void SpawnText(string text)
    {
        _answerText = text;
        _text_gameObject = new GameObject("TaskText");
        _text_gameObject.transform.SetParent(this._holder);
        _taskText = _text_gameObject.AddComponent<Text>();
        this.SetTextSettings(_answerText);
    }
    private void SetTextSettings(string text)
    {
        _taskText.text = _findText + text;
        _taskText.alignment = TextAnchor.MiddleCenter;
        _taskText.font = _font;
        _taskText.rectTransform.localPosition = _textPosition;
    }

    public void DestroyText(GameObject text)
    {
        Destroy(text);
    }
}
