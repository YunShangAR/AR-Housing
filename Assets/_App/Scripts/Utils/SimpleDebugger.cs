using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDebugger : MonoBehaviour
{
    public void Log(string str)
    {
        print(str);
    }

    public void Log(GameObject go)
    {
        print(go);
    }
}
