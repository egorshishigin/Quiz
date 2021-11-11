using System;
using UnityEngine;

[Serializable]
public class Level
{
    [SerializeField]
    private int _cardCount;

    public int GetCardCount()
    {
        return this._cardCount;
    }
}
