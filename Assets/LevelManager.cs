using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	// Centralized Level Management
	
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}
	
	public void QuitRequest(){
		// Does not work in game or web player mode
		Application.Quit();
	}
}
