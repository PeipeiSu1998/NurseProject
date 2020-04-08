using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.CameraRig.UnityXRCameraRig.Input;
using VRTK.Prefabs.Interactions.Interactables;

public class ButtonMovement : MonoBehaviour
{
    private bool touched;
    private Transform buttonTransform;
    public Animator materasso_head_animator;


    // Start is called before the first frame update
    void Start()
    {
        touched = false;
        buttonTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        }

    public void OnTriggerEnter(Collider other)
    {
       touched = true;
    }

    public void OnTriggerExit(Collider other)
    {
        touched = false;
    }

    public void ButtonPressedAction()
    {
        if (touched)
        {
            if(gameObject.name == "Button1")
            {
                materasso_head_animator.SetBool("up", true);
            }
            Debug.Log("Button Pressed");
        }
    }

    public void ButtonReleasedAction()
    {
        Debug.Log("Button Released");
    }
    }

