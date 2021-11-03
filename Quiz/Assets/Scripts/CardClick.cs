using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CardClick : MonoBehaviour
{
    private Answer _answerCkeck;
    
    public void SetAnswer(Answer answer)
    {
        this._answerCkeck = answer;
    }

    public void PointerDown()
    {
        this._answerCkeck.GiveAnswer(gameObject);
    }

}
