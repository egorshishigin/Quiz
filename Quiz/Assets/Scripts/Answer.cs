using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Answer : MonoBehaviour
{
    [SerializeField]
    private string _answer;
    public UnityEvent<GameObject> RightAnswer;
    public UnityEvent<GameObject> WrongAnswer;
    public UnityEvent<string> ShowText;
    private readonly System.Random _random = new System.Random();

    public void SelectAnswer(List<string> answers)
    {
        _answer = answers[_random.Next(answers.Count)];
        ShowText.Invoke(_answer);
    }

    public void GiveAnswer(GameObject card)
    {
        if (card.name == _answer)
        {
            RightAnswer.Invoke(card);
        }
        else
        {
            WrongAnswer.Invoke(card);
        }
    }
}
