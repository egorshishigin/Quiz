using UnityEngine;
using DG.Tweening;

public class ScaleCard : MonoBehaviour
{
    [SerializeField]
    private float _duration;

    public void ScaleUp(GameObject card)
    {
        card.transform.DOScale(0f, 0f);
        card.transform.DOScale(transform.localScale.x, this._duration);
    }

    public void ScaleDown(GameObject card)
    {
        card.transform.DOScale(0f, this._duration);
    }
}
