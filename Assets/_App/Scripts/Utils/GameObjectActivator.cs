using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectActivator : MonoBehaviour
{
    public void Activate(GameObject go)
    {
        go.SetActive(true);
    }

    public void Deactivate(GameObject go)
    {
        go.SetActive(false);
    }

    public void Reverse(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
}
