using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Prefabs.CameraRig.UnityXRCameraRig.Input;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        Debug.Log(gameObject.tag);
        if (gameObject.CompareTag("Tutorial"))
        {
            SceneManager.LoadScene("Tutorial");
        }else if (gameObject.CompareTag("Test"))
        {
            SceneManager.LoadScene("Test");
        }else if (gameObject.CompareTag("Quit"))
        {
            Debug.Log("Quit");
        }
    }
}
