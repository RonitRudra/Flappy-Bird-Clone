using UnityEngine;
using System.Collections;

public class collisionDetect : MonoBehaviour {
	private LevelManager levelManager;
	private ScoreController scoreController;
	private AudioSource[] sources;
	private AudioSource hit_sfx;
	private float clipLength;
	
	// Top and bottom colliders to trigger gameover
	// Pipe colliders to trigger gameover
	
	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		scoreController = GameObject.FindObjectOfType<ScoreController>();
		// Find all objects with audio source component
		// Find audio source with particular name
		sources = GameObject.FindObjectsOfType<AudioSource>();
		foreach(AudioSource audio in sources){
			if(audio.name=="Hit SFX"){
				hit_sfx = audio;
			}
		}
		clipLength = hit_sfx.clip.length;
	}
	
	
	void OnTriggerEnter2D(Collider2D collider){
		// checking parent tag as collider set on child
		if(collider.transform.parent.tag=="Player"){
			hit_sfx.Play();
			//Debug.Log("Game Over");
			// Upadate Scores through Score Controller
			scoreController.updateScores();
			levelManager.InvokedLoad();
		}
	}
	
	public float getClipLength(){
		return clipLength;
	}
}
