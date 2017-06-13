using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	// Displays Score on Screen
	// Saves Highscore in PlayerPrefs
	
	private PlayerController player;
	private Text text;
	// Use this for initialization
	void Start () {
		// Get text component of same gameobject
		text = GetComponent<Text>();
		// Find component of another gameobject
		player = GameObject.FindObjectOfType<PlayerController>();
		// Set initial score
		text.text = player.getScore().ToString();
	}
	
	// Update is called once per frame
	void Update () {
		// Update Score every frame
		PreferenceManager.setCurrentScore(player.getScore());
		text.text = player.getScore().ToString();
		
	}
	
	public void updateScores(){
		float highscore = PreferenceManager.getHighScore();
		float currentscore = PreferenceManager.getCurrentScore();
		if(currentscore>highscore){
			PreferenceManager.setHighScore(currentscore);
		}
	}
}
