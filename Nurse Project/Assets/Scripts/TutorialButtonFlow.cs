using System.Collections.Generic;
using UnityEngine;

public class TutorialButtonFlow : MonoBehaviour
{
    public TutorialGameFlow tutorialGameFlow;
    public List<ControllerStateManager> controllerStateManagers;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "left_touch_controller_model_skel" || other.gameObject.name == "right_touch_controller_model_skel")
        {
            foreach (ControllerStateManager c in controllerStateManagers)
            {
                if (c.triggerPressed)
                {
                    if (gameObject.name == "Button1" && tutorialGameFlow.snapdropzone && !tutorialGameFlow.button1)
                    {
                        tutorialGameFlow.Button1Done();
                        Debug.Log("button1 : " + tutorialGameFlow.button1 + ", button2: " + tutorialGameFlow.button2 + ", button3: " + tutorialGameFlow.button3 + ", button4: " + tutorialGameFlow.button4 + ", button5: " + tutorialGameFlow.button5);
                    }
                    else if (gameObject.name == "Button2" && tutorialGameFlow.button1 && !tutorialGameFlow.button2)
                    {
                        tutorialGameFlow.Button2Done();
                        Debug.Log("button1 : " + tutorialGameFlow.button1 + ", button2: " + tutorialGameFlow.button2 + ", button3: " + tutorialGameFlow.button3 + ", button4: " + tutorialGameFlow.button4 + ", button5: " + tutorialGameFlow.button5);
                    }
                    else if (gameObject.name == "Button3" && tutorialGameFlow.button2 && !tutorialGameFlow.button3)
                    {
                        tutorialGameFlow.Button3Done();
                        Debug.Log("button1 : " + tutorialGameFlow.button1 + ", button2: " + tutorialGameFlow.button2 + ", button3: " + tutorialGameFlow.button3 + ", button4: " + tutorialGameFlow.button4 + ", button5: " + tutorialGameFlow.button5);
                    }
                    else if (gameObject.name == "Button4" && tutorialGameFlow.button3 && !tutorialGameFlow.button4)
                    {
                        tutorialGameFlow.Button4Done();
                        Debug.Log("button1 : " + tutorialGameFlow.button1 + ", button2: " + tutorialGameFlow.button2 + ", button3: " + tutorialGameFlow.button3 + ", button4: " + tutorialGameFlow.button4 + ", button5: " + tutorialGameFlow.button5);
                    }
                    else if (gameObject.name == "Button5" && tutorialGameFlow.button4 && !tutorialGameFlow.button5)
                    {
                        tutorialGameFlow.Button5Done();
                        Debug.Log("button1 : " + tutorialGameFlow.button1 + ", button2: " + tutorialGameFlow.button2 + ", button3: " + tutorialGameFlow.button3 + ", button4: " + tutorialGameFlow.button4 + ", button5: " + tutorialGameFlow.button5);
                    }
                }
            }
        }
    }
}
