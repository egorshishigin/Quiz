using UnityEngine;
using UnityEngine.Events;

public class RestartGame : MonoBehaviour
{
    [SerializeField]
    private float _delay;
    public UnityEvent Restarted;

    private void Restart()
    {
        Restarted.Invoke();
    }

    public void OnRestartGame()
    {
        Debug.Log("Restarted");
        Invoke("Restart", _delay);
    }
}
