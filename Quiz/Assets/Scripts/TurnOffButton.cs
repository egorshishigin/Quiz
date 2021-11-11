using UnityEngine;
using UnityEngine.EventSystems;

public class TurnOffButton : MonoBehaviour
{
    private EventTrigger _buttonEventTrigger;

    public void DisableButton(GameObject card)
    {
        _buttonEventTrigger = card.GetComponent<EventTrigger>();
        _buttonEventTrigger.enabled = false;
    }
}
