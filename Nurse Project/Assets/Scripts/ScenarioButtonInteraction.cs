﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.CameraRig.UnityXRCameraRig.Input;
using VRTK.Prefabs.Interactions.Interactables;
using Zinnia.Data.Type.Transformation.Conversion;

public class ScenarioButtonInteraction : MonoBehaviour
{
    private string buttonName;
    public delegate void MyDelegate(string x);
    public static MyDelegate chooseName;
    private int correctCounter;
    private bool wasClicked;
    public List<ControllerStateManager> controllerStateManagers;

    private void OnEnable() {
        chooseName += SetButtonName;
    }
    private void OnDisable() {
        chooseName -= SetButtonName;
    }
    public void SetButtonName(string name){
        buttonName = name;
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "left_touch_controller_model_skel" || other.gameObject.name == "right_touch_controller_model_skel"){
            foreach (ControllerStateManager c in controllerStateManagers){
                if (c.triggerPressed && !wasClicked){
                    wasClicked = true;
                    if(this.gameObject.name.Equals(buttonName))
                        TestScenarioManager.choosingScenario(1);
                    else
                        TestScenarioManager.choosingScenario(-1);
                }
            }
        }
        else
            wasClicked = false;

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "left_touch_controller_model_skel" || other.gameObject.name == "right_touch_controller_model_skel"){
            if(wasClicked){
                wasClicked = false;
                if(this.gameObject.name.Equals(buttonName))
                    TestScenarioManager.choosingScenario(1);
                else
                    TestScenarioManager.choosingScenario(-1);
            }
        }
    }
}
