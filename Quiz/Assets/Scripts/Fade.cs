using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Fade : MonoBehaviour
{
    [SerializeField]
    private Image _image;

    public void FadeIn(float duration)
    {
        StartFade(1, duration);

    }

    public void FadeOut(float duration)
    {
        StartFade(0, duration);
    }

    private void StartFade(float value, float duration)
    {
        _image.DOFade(value, duration);
    }
}
