using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
    public List<ControllerStateManager> controllerStateManagers; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*   private void OnCollisionStay(Collision collision)
       {
           if(collision.gameObject.name == "TutorialButton")
           {
               SceneManager.LoadScene("Tutorial");
           }
       }*/

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Tutorial");
    }

    /*  private void OnTriggerEnter(Collider other)
      {
          Debug.Log("Here!");
          foreach (ControllerStateManager c in controllerStateManagers)
          {
              if (c.triggerPressed)
              {

                  if (gameObject.name == "TutorialButton")
                  {
                      SceneManager.LoadScene("Tutorial");
                  }else if(gameObject.name == "TestButtonSingleGame")
                  {

                  }else if(gameObject.name == "TestButtonSurvivalGame")
                  {

                  }else if(gameObject.name == "QuitButton")
                  {
                      Application.Quit();
                  }
              }
          }
      }*/
}
