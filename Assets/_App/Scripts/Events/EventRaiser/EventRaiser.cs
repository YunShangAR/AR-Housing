using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventRaiser : MonoBehaviour
{
    public UnityEvent Event;

    public void Raise()
    {
        Event?.Invoke();
    }
}
