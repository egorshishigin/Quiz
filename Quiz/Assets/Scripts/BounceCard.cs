using UnityEngine;
using DG.Tweening;

public class BounceCard : MonoBehaviour
{
    [SerializeField]
    private float _duration;
    [SerializeField]
    private int _vibrato;

    public void Bounce(GameObject card)
    {
        card.transform.DOShakePosition(_duration, strength: new Vector3(0.5f, 0, 0), vibrato: _vibrato, randomness: 1, snapping: false, fadeOut: true);
    }
}
