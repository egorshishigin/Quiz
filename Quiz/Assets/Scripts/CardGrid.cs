using UnityEngine;
using UnityEngine.UI;
public class CardGrid : MonoBehaviour
{
    [SerializeField]
    private Transform _parent;

    [SerializeField]
    private Vector2 _spacing;

    [SerializeField]
    private Vector2 _cellSize;

    [SerializeField]
    private float _width;
    [SerializeField]
    private float _height;

    public void SpawnGrid(int cardsCount)
    {
        GameObject gameObject = new GameObject("Grid");
        gameObject.transform.SetParent(this._parent);
        gameObject.transform.localPosition = new Vector2(0f, 0f);
        this.LayoutGroupSetting(gameObject.AddComponent<GridLayoutGroup>());
        base.GetComponent<Spawner>().SpawnCards(cardsCount, gameObject.transform);
    }

    private void LayoutGroupSetting(GridLayoutGroup layoutGroup)
    {
        layoutGroup.spacing = this._spacing;
        layoutGroup.cellSize = this._cellSize;
        layoutGroup.transform.localScale = new Vector2(_width, _height);
        layoutGroup.childAlignment = TextAnchor.MiddleCenter;
    }
}


