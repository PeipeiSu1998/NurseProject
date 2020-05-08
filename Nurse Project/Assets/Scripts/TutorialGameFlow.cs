using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject sceneChanger;
    public Text displayedText;

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
        displayedText.text = "Please click on A or X button in your controller to show the instructions";
    }
    void Update()
    {
        if (instruction && teleport && grab && snapdropzone && button1 && button2 && button3 && button4 && button5)
        {
            sceneChanger.SetActive(true);
        }
    }

    public void InstructionButtonDone()
    {
        if (!instruction)
        {
            instruction = true;
            displayedText.text = "Please take a look at the instructions and try to teleport somewhere.";

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }

    public void TeleportButtonDone()
    {
        if(instruction && !teleport)
        {
            teleport = true;
            displayedText.text = "Please grab the button panel next to the bed by using the grip.";

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }

    public void GrabDone()
    {
        if(teleport && !grab)
        {
            grab = true;
            displayedText.text = "Well done, please put the button panel back to its place.";

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }

    public void SnapDropZoneDone()
    {
        if (grab && !snapdropzone)
        {
            snapdropzone = true;
            displayedText.text = "Please use the trigger on your controller to click the first button. You can use it to put the patient in the Fowlers position. It can help with difficulties with breathing or dyspnoe.";

            Debug.Log("instruction: " + instruction + ", teleport: " + teleport + ", grab: " + grab + ", snapdropzone: " + snapdropzone);
        }
    }

    public void Button1Done()
    {
        if(snapdropzone && !button1)
        {
            button1 = true;
            displayedText.text = "Now click the second button. You can use it to regulate Fowlers position to a lower or higher position for the upper body. It can prevent naucea, stop nosebleeding by preventing high blood pressure in the head/nose area or help with a night cough.";
        }
    }

    public void Button2Done()
    {
        if(button1 && !button2)
        {
            button2 = true;
            displayedText.text = "Now click the third button. You can use it to regulate Fowlers position to a lower position for the lower body. It can ease pain in legs, so you can use it when you are giving the patient a compression on the legs.";
        }
    }

    public void Button3Done()
    {
        if(button2 && !button3)
        {
            button3 = true;
            displayedText.text = "Now click the fourth button. Use it for legs with edema, it helps blod in legs to pass towards the heart which eases the pressure and prevents/eases the oedema.";
        }
    }

    public void Button4Done()
    {
        if(button3 && !button4)
        {
            button4 = true;
            displayedText.text = "Now click the fifth button. The bed will return to its original position.";
        }
    }

    public void Button5Done()
    {
        if(button4 && !button5)
        {
            button5 = true;
            displayedText.text = "Well done, now you can teleport to the circle at the middle of this room, to get into the test scene.";
        }
    }

    
}
