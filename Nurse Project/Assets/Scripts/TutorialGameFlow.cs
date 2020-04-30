using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialGameFlow : MonoBehaviour
{
    private bool instruction;
    private bool teleport;
    private bool grab;
    public bool snapdropzone;
    public bool button1;
    public bool button2;
    public bool button3;
    public bool button4;
    public bool button5;
    // Start is called before the first frame update
    void Start()
    {
        instruction = false;
        teleport = false;
        grab = false;
        snapdropzone = false;
        button1 = false;
        button2 = false;
        button3 = false;
        button4 = false;
        button5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstructionButtonDone()
    {
        if (!instruction)
        {
            instruction = true;

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }

    public void TeleportButtonDone()
    {
        if(instruction && !teleport)
        {
            teleport = true;

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }

    public void GrabDone()
    {
        if(teleport && !grab)
        {
            grab = true;

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }

    public void SnapDropZoneDone()
    {
        if(grab && !snapdropzone)
        {
            snapdropzone = true;

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }
}
