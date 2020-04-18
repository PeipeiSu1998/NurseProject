using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerStateManager : MonoBehaviour
{
    public bool triggerTouched;
    public bool triggerPressed;

    private void Awake()
    {
        triggerPressed = false;
        triggerTouched = false;
    }

    public void TriggerTouched()
    {
        triggerTouched = true;
    }

    public void TriggerNotTouched()
    {
        triggerTouched = false;
    }

    public void TriggerPressed()
    {
        triggerPressed = true;
    }

    public void TirggerNotPressed()
    {
        triggerPressed = false;
    }
}
