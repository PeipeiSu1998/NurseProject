using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeHolder : MonoBehaviour
{
    public GameMode mode;
	public string feedback = "";
    private static GameModeHolder instance = null;
 	public static GameModeHolder Instance {
 	    get { return instance; }
 	}
 	void Awake() {
 	    if (instance != null && instance != this) {
 	        Destroy(this.gameObject);
 	        return;
 	    } else {
 	       instance = this;
		}
        DontDestroyOnLoad(this);
 	}
	 public void SetFeedback(int incorrect){
		if(incorrect <= 2)
			feedback = "Great job! ";
		else
			feedback = "Good job, but maybe you should practice a bit more? ";
		feedback += "You made " + incorrect + " mistakes.";
		 this.feedback = feedback;
	 }
	 public string GetFeedback(){
		 return feedback;
	 }
}
