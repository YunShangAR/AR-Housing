using System.Collections;
using UnityEngine;

public class DelayedEventRaiser : EventRaiser
{
    public float delay;

    public new void Raise()
    {
        StartCoroutine(RaiseImpl());
    }

    private IEnumerator RaiseImpl()
    {
        yield return new WaitForSeconds(delay);
        base.Raise();
    }
}