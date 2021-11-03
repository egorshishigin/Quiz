using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class CardData
{
    [SerializeField]
    private string _identifier;

    [SerializeField]
    private Sprite _sprite;

    public string GetID()
    {
        return this._identifier;
    }

    public Sprite GetSprite()
    {
        return this._sprite;
    }
}
