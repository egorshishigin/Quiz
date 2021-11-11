using UnityEngine;

public class SelectCardData : MonoBehaviour
{
    [SerializeField]
    private CardBundleData[] _cardsData;
    private readonly System.Random _random = new System.Random();

    public CardData[] SelecetData()
    {
        return _cardsData[_random.Next(this._cardsData.Length)].GetCardData();
    }
}
