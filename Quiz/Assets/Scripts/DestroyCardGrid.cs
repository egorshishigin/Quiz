using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCardGrid : MonoBehaviour
{
    [SerializeField]
    private float _delay;

    private GameObject _card;

    public void GetPressedCard(GameObject card)
    {
        this._card = card;
        Invoke("DestroyGrid", _delay);
    }

    private void DestroyGrid()
    {
        Destroy(_card.transform.parent.gameObject);
    }
}
