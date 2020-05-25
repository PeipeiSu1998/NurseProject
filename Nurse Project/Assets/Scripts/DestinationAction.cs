using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinationAction : MonoBehaviour
{

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void TestNormal()
    {
        GameModeHolder.Instance.mode = GameMode.normal;
        SceneManager.LoadScene("Test");
    }

    public void TestSurvival()
    {
        GameModeHolder.Instance.mode = GameMode.survival;
        SceneManager.LoadScene("Test");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
