using UnityEngine;
using VRTK;
using VRTK.Prefabs.CameraRig.UnityXRCameraRig.Input;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void ChangeScene()
    {
        Debug.Log(gameObject.tag);
        if (gameObject.CompareTag("Tutorial"))
        {
            SceneManager.LoadScene("Tutorial");
        }else if (gameObject.CompareTag("TestSingle"))
        {
            GameModeHolder.Instance.mode = GameMode.normal;
            SceneManager.LoadScene("Test");
        }else if (gameObject.CompareTag("TestSurvival"))
        {
            GameModeHolder.Instance.mode = GameMode.survival;
            SceneManager.LoadScene("Test");
        }else if (gameObject.CompareTag("Quit"))
        {
            #if UNITY_EDITOR
        	UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit ();
            #endif
            Debug.Log("Quit");
        }
    }
}
