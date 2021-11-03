using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Fade : MonoBehaviour
{
	[SerializeField]
	private Image _image;
	public void FadeIn(float duration)
	{
		if(this._image != null)
        {
			Color endColor = new Color(this._image.color.r, this._image.color.g, this._image.color.b, 1f);
			this.StartFade(endColor, duration);
			return;
		}

	}

	public void FadeOut(float duration)
	{
		if (this._image != null)
		{
			Color endColor = new Color(this._image.color.r, this._image.color.g, this._image.color.b, 0f);
			this.StartFade(endColor, duration);
			return;
		}
	}
	private void StartFade(Color endColor, float duration)
	{
		_image.DOColor(endColor, duration);
	}
}
