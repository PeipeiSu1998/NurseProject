using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerStateManager : MonoBehaviour
{
    public bool triggerTouched;

    private void Awake()
    {
        triggerTouched = false;
    }

    public void TriggerTouched()
    {
        triggerTouched = true;
    }

    public void TriggerReleased()
    {
        triggerTouched = false;
    }
}
