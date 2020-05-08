using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeHolder : MonoBehaviour
{
    public GameMode mode;
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
}
