using UnityEngine;

[CreateAssetMenu(fileName = "New CardBundleData", menuName = "Card Bundle Data", order = 10)]
public class CardBundleData : ScriptableObject
{
    [SerializeField]
    private CardData[] _cardData;

    public CardData[] GetCardData()
    {
        return this._cardData;
    }
}
