using UnityEngine;
using System.Collections;

public class collisionDetect : MonoBehaviour {
	private LevelManager levelManager;
	
	// Top and bottom colliders to trigger gameover
	// Pipe colliders to trigger gameover
	
	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	
	void OnTriggerEnter2D(Collider2D collider){
		// checking parent tag as collider set on child
		if(collider.transform.parent.tag=="Player"){
			//Debug.Log("Game Over");
			levelManager.LoadLevel("03 Restart");
			
		}
	}
}
