using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Prefabs.CameraRig.UnityXRCameraRig.Input;

public class MenuButtons : MonoBehaviour
{
    public GameObject gameObject;

    public GameObject validCube;
    public UnityButtonAction unityButtonAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (validCube.activeSelf)
        {
            if (other.gameObject.CompareTag("Exist"))
            {
                gameObject.SetActive(false);
            }
        }
    }
}
