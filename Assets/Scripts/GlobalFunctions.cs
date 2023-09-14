using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalFunctions: MonoBehaviour
{
    public static void Quit()
    {
        Application.Quit();
    }

    public static void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
    
}
