using System.Collections;
using System.Collections.Generic;
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

    public void SetCardCount(int count)
    {
        this._cardCount = count;
    }
}
