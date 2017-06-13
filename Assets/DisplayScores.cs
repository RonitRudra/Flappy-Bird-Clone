using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScores : MonoBehaviour {
	// Put text of size 2 in inspector
	public Text[] text;
	
	void Start(){
		text[0].text = PreferenceManager.getCurrentScore().ToString();
		text[1].text = PreferenceManager.getHighScore().ToString();
	}
}
