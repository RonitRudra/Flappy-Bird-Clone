using UnityEngine;
using System.Collections;

public class PreferenceManager : MonoBehaviour {
	
	// Wrapper class that facilitates use of PlayerPrefs
	// Does away with remembering keys
	//
	
	// Define keys to be used in player preference file
	const string DIFFICULTY_KEY = "Difficulty";
	const string VOLUME_KEY = "Music";
	const string SFX_KEY = "SFX";
	const string HIGHSCORE_KEY = "HighScore";
	const string CURRENT_SCORE_KEY = "CurrentScore";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	#region Getter Setter functions
	
	public static void setDifficulty(float difficulty){
		PlayerPrefs.SetFloat(DIFFICULTY_KEY,difficulty);
	}
	
	public static float getDifficulty(){
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	
	public static void setVolume(float volume){
		if(volume>=0f && volume<=1f)
			{PlayerPrefs.SetFloat(VOLUME_KEY,volume);}
		else{
			volume = Mathf.Clamp(volume,0f,1f);
			PlayerPrefs.SetFloat(VOLUME_KEY,volume);
		}
	}
	
	public static float getVolume(){
		return PlayerPrefs.GetFloat(VOLUME_KEY);
	}
	
	public static void setSFX(float volume){
		if(volume>=0f && volume<=1f)
		{PlayerPrefs.SetFloat(SFX_KEY,volume);}
		else{
			volume = Mathf.Clamp(volume,0f,1f);
			PlayerPrefs.SetFloat(SFX_KEY,volume);
		}
	}
	
	public static float getSFX(){
		return PlayerPrefs.GetFloat(SFX_KEY);
	}
	
	public static void setHighScore(float score){
		PlayerPrefs.SetFloat(HIGHSCORE_KEY,score);
	}
	
	public static float getHighScore(){
		return PlayerPrefs.GetFloat(HIGHSCORE_KEY);
	}
	
	public static void setCurrentScore(float score){
		PlayerPrefs.SetFloat(CURRENT_SCORE_KEY,score);
	}
	
	public static float getCurrentScore(){
		return PlayerPrefs.GetFloat(CURRENT_SCORE_KEY);
	}
	
	#endregion
}
