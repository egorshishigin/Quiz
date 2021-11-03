using System;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField]
	private GameObject _card;

	[SerializeField]
	private Vector2 _localScale;

	private bool _isFirstLevel = true;
	[SerializeField]
	private Answer _answer;

	private readonly System.Random _random = new System.Random();

    public void SpawnCards(int cardsCount, Transform holder)
	{
		CardData[] cards_array = base.GetComponent<SelectCardData>().SelecetData();

		if (cards_array.Length < cardsCount)
		{
			throw new Exception("cardData < cardsCount");
		}

		List<int> selcted_list = new List<int>();
		List<string> answers_list = new List<string>();
		for(int i=0; i < cardsCount; i++)
        {
			int randomCardID;
			do
			{
				randomCardID = _random.Next(cards_array.Length);

			} while (selcted_list.Contains(randomCardID));
			selcted_list.Add(randomCardID);			
			CardData cardData = cards_array[randomCardID];
			answers_list.Add(cardData.GetID());
			GameObject card_gameObject = Instantiate<GameObject>(_card, holder);
			card_gameObject.name = cardData.GetID();
			card_gameObject.GetComponent<Card>().SetID(cardData.GetID());
			card_gameObject.GetComponent<Card>().SetSprite(cardData.GetSprite());
			card_gameObject.GetComponent<CardClick>().SetAnswer(_answer);
            if (_isFirstLevel)
            {
				ScaleCard scaleCard;
				if(base.TryGetComponent<ScaleCard>(out scaleCard))
                {
					scaleCard.ScaleUp(card_gameObject);
                }

            }
		}
		base.GetComponent<Answer>().SelectAnswer(answers_list);
		_isFirstLevel = false;
	}

	public void SetFirstTimeFlag()
	{
		_isFirstLevel = true;
	}

	private void OnEnable()
	{
		_answer = base.GetComponent<Answer>();
	}
}
