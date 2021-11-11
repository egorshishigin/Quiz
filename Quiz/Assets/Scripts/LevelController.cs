using UnityEngine;
using UnityEngine.Events;

public class LevelController : MonoBehaviour
{
    [SerializeField]
    private Level[] _levels;
    [SerializeField]
    private float _delay;
    private int _level;
    public UnityEvent<int> StartGame;
    public UnityEvent EndGame;

    private void Start()
    {
        StartGame.Invoke(_levels[_level].GetCardCount());
    }

    public void NextLevel()
    {
        _level++;
        if (_level == _levels.Length)
        {
            Debug.Log("Game end");
            EndGame.Invoke();
        }
        else
        {
            StartGame.Invoke(_levels[_level].GetCardCount());
        }

    }

    public void StartLevel()
    {
        Invoke("NextLevel", _delay);
    }

    public void NewGame()
    {
        _level = 0;
        StartGame.Invoke(_levels[_level].GetCardCount());

    }

    public void StartNewGame()
    {
        Invoke("NewGame", _delay);
    }
}
