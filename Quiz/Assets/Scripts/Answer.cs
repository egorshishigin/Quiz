using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Answer : MonoBehaviour
{
    [SerializeField]
    private List<string> _answers;
    [SerializeField]
    private string _answer;

    private BounceCard _bounceCard;

    public UnityEvent<GameObject> RightAnswer;
    public UnityEvent<GameObject> WrongAnswer;

    public UnityEvent<string> ShowText;
    public UnityEvent<GameObject> DestroyText;

    private readonly System.Random _random = new System.Random();


    public void SelectAnswer(List<string> answers)
    {
        _answer = answers[_random.Next(answers.Count)];
        ShowText.Invoke(_answer);
    }

    public void GiveAnswer(GameObject card)
    {
        if (card.GetComponent<Card>().GetID() == _answer)
        {
            RightAnswer.Invoke(card);
            DestroyText.Invoke(GameObject.Find("TaskText"));
        }
        else
        {
            WrongAnswer.Invoke(card);
        }
    }
}
