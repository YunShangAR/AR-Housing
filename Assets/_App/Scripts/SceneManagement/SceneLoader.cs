using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Load(string sceneName)
    {
        try
        {
            SceneManager.LoadScene(sceneName);
        }
        catch
        {
            Debug.LogError($"Load scene '{sceneName}' Failed.");
        }
    }

    public void Load(int index)
    {
        try
        {
            SceneManager.LoadScene(index);
        }
        catch
        {
            Debug.LogError($"Load scene at index ['{index}'] Failed.");
        }
    }
}
