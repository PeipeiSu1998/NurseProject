using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackManager : MonoBehaviour
{
    public Text feedbackHolder;
    private string feedback;
    void Start()
    {
        feedback = GameModeHolder.Instance.GetFeedback();
        if(feedback == "")
            feedbackHolder.gameObject.transform.parent.parent.gameObject.SetActive(false);
        else{
            feedbackHolder.gameObject.transform.parent.gameObject.SetActive(true);
            feedbackHolder.text = feedback;
        }
    }

}
