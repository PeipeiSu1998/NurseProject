using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScenarioManager : MonoBehaviour
{
        public Text text;
    public GameObject[] buttons;
    private string script;
    public delegate void MyDelegate();
    public static MyDelegate choosingScenario;
    private void OnEnable() {
        choosingScenario += ChooseScenario;
    }
    private void OnDisable() {
        choosingScenario -= ChooseScenario;
    }
    private void Start() {
        ChooseScenario();
    }

    public void ChooseScenario(){
        int caseNo = Random.Range(0, 6);
        switch(caseNo){
            case 0:
                script = "Your patient has difficulties with breathing. Adjust the bed accordingly.";
                ScenarioButtonInteraction.chooseName("Button1");
                break;
            case 1: 
                script = "Your patient has dyspnoe. Adjust the bed accordingly.";
                ScenarioButtonInteraction.chooseName("Button1");
                break;
            case 2:
                script = "Your patient has naucea. Adjust the bed accordingly.";
                ScenarioButtonInteraction.chooseName("Button2");
                break;
            case 3:
                script = "Your patient has nosebleeding. Adjust the bed accordingly.";
                ScenarioButtonInteraction.chooseName("Button2");
                break;
            case 4:
                script = "Your patient has night cough. Adjust the bed accordingly.";
                ScenarioButtonInteraction.chooseName("Button2");
                break;
            case 5:
                script = "You need to give your patient a compression on the legs. Adjust the bed to ease the pain.";
                ScenarioButtonInteraction.chooseName("Button3");
                break;
            case 6:
                script = "Your patient has edema of the legs. Adjust the bed accordingly.";
                ScenarioButtonInteraction.chooseName("Button4");
                break;
        }
        text.text = script;

    }
}
