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
    public delegate void MyDelegate1(int i);
    public static MyDelegate1 inputGiven;
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
                if (c.triggerPressed){
                    if(inputGiven != null){
                        if(this.gameObject.name.Equals(buttonName))
                            inputGiven(1);
                        else
                            inputGiven(-1);
                    }
                }
            }
        }

    }
}
