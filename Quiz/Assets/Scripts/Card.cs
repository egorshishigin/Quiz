using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField]
    private string _id;

    public string GetID()
    {
        return this._id;
    }
    public void SetID(string id)
    {
        this._id = id;
    }
    public void SetSprite(Sprite sprite)
    {
       base.GetComponent<Image>().sprite = sprite;
       base.GetComponent<Image>().SetNativeSize();
    }
}
