﻿using UnityEngine;
public enum GameMode
{
    normal, survival
}
public class GameModeHolder : MonoBehaviour
{
    public GameMode mode;
	private string feedback = "";
    private static GameModeHolder instance = null;
 	public static GameModeHolder Instance {
 	    get { return instance; }
 	}
 	private void Awake() {
 	    if (instance != null && instance != this) {
 	        Destroy(this.gameObject);
 	        return;
 	    } else {
 	       instance = this;
		}
        DontDestroyOnLoad(this);
 	}
	 //Set feedback for the user. If the mode is normal the num is amount of incorrect answers, otherwise it is the number of correct answers.
	 public void SetFeedback(int num){
		if((num <= 2 && mode == GameMode.normal) || (num >= 5 && mode == GameMode.survival))
			feedback = "Great job!";
		else
			feedback = "Good job, but maybe you should practice a bit more?";
		feedback += mode == GameMode.normal ? "<br> You made " + num + " mistakes." : "<br> You got " + num + "correct.";
	 }
	 public string GetFeedback(){
		 return feedback;
	 }
}
