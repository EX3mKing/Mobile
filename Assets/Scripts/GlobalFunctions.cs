using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalFunctions: MonoBehaviour
{
    public static void Quit()
    {
        Application.Quit();
        Debug.LogWarning("Exited");
    }
    
    public static IEnumerator Quit(float time)
    {
        yield return new WaitForSeconds(time);
        Application.Quit();
        Debug.LogWarning("Exited");
    }

    public static void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public static IEnumerator LoadNextScene(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public static void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
    
    public static IEnumerator LoadSceneByIndex(int index, float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(index);
    }
    
    public static Color GetColor()
    {
        // to create lighter colours:
        // take a random integer between 0 & 128 (rather than between 0 and 255)
        // and then add 127 to make the colour lighter

        Color color = new Color();

        color.r = Random.Range(0f, 0.5f) + 0.3f;
        color.b = Random.Range(0f, 0.5f) + 0.3f;
        color.g = Random.Range(0f, 0.5f) + 0.3f;
        color.a = 1f;

        return color;
    }
    
}
