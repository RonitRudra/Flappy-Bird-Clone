using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	// Centralized Level Management
	// Set true only for splash screen
	public bool autoLoad = false;
	// how long splash is displayed
	private float loadDelay = 3f;
	
	// Load new scene
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}
	
	public void QuitRequest(){
		// Does not work in game or web player mode
		//Application.Quit();
		System.Diagnostics.Process.GetCurrentProcess().Kill();
	}
	
	// Defined to work with invoke (Cannot pass arguments to function called through invoke)
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel+1);
	}
	
	void Start(){
		if(autoLoad==true){
			Invoke("LoadNextLevel",loadDelay);
		}
	}
	
	public void InvokedLoad(){
		float clipLength = GameObject.FindObjectOfType<collisionDetect>().getClipLength();
		Invoke ("LoadNextLevel",clipLength);
	}
}
