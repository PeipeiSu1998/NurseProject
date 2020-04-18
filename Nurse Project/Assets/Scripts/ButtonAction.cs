using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.CameraRig.UnityXRCameraRig.Input;
using VRTK.Prefabs.Interactions.Interactables;
using Zinnia.Data.Type.Transformation.Conversion;

public class ButtonAction : MonoBehaviour
{
    private Transform buttonTransform;
    public Animator materasso_head_animator;
    public Animator materasso_thigh_animator;
    public Animator materasso_leg_animator;
    public List<ControllerStateManager> controllerStateManagers;


    // Start is called before the first frame update
    void Start()
    {
        buttonTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
              foreach (ControllerStateManager c in controllerStateManagers)
        {
              if (c.triggerPressed)
            {
                if (gameObject.name == "Button1")
                {
                    materasso_head_animator.SetBool("up", true);
                    materasso_thigh_animator.SetBool("tilt", true);
                    materasso_leg_animator.SetBool("tilt", true);
                    materasso_leg_animator.SetBool("up", false);
                }
                else if (gameObject.name == "Button2")
                {
                    materasso_head_animator.SetBool("up", true);
                    materasso_thigh_animator.SetBool("tilt", false);
                    materasso_leg_animator.SetBool("tilt", false);
                    materasso_leg_animator.SetBool("up", false);
                }
                else if (gameObject.name == "Button3")
                {
                    materasso_head_animator.SetBool("up", false);
                    materasso_thigh_animator.SetBool("tilt", true);
                    materasso_leg_animator.SetBool("tilt", true);
                    materasso_leg_animator.SetBool("up", false);
                }
                else if (gameObject.name == "Button4")
                {
                    materasso_head_animator.SetBool("up", false);
                    materasso_thigh_animator.SetBool("tilt", true);
                    materasso_leg_animator.SetBool("up", true);
                    materasso_leg_animator.SetBool("tilt", false);
                }
                else if (gameObject.name == "Button5")
                {
                    materasso_head_animator.SetBool("up", false);
                    materasso_thigh_animator.SetBool("tilt", false);
                    materasso_leg_animator.SetBool("tilt", false);
                    materasso_leg_animator.SetBool("up", false);
                }
                Debug.Log("Button Pressed");
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Button Release");
    }
}

