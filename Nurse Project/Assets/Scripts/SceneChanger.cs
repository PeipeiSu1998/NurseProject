using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "left_touch_controller_model_skel" || other.gameObject.name == "right_touch_controller_model_skel") { 
 //           if(other.gameObject.name == "VRTK Prefabs")  {
            if (gameObject.name == "SceneChanger_Tutorial")
            {
                Debug.Log("Tutorial");
                SceneManager.LoadScene("Tutorial");
            }
            else if (gameObject.name == "SceneChanger_Test_Normal")
            {
                Debug.Log("Test_Normal");
                GameModeHolder.Instance.mode = GameMode.normal;
                SceneManager.LoadScene("Test");
            }
            else if (gameObject.name == "SceneChanger_Test_Survival")
            {
                Debug.Log("Test_Survival");
                GameModeHolder.Instance.mode = GameMode.survival;
                SceneManager.LoadScene("Test");
            }
            else if (gameObject.name == "Quit")
            {
                Application.Quit();
            }
        }
    }
}
