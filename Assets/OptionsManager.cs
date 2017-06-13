using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour {
	//TODO Set Up SFX and Difficulty
	// Operates on the options menu
	// Uses LevelManager to switch to main menu
	// Uses PlayerPrefs through PreferenceManager for settings
	
	
	// Drag and drop sliders to inspector
	public Slider difficultySlider;
	public Slider musicSlider;
	public Slider sfxSlider;
	
	//variables for unsaved changes
	float difficulty;
	float music;
	float sfx;
	
	// Get LevelManager privately
	LevelManager levelManager;
	// Get MusicManager privately
	MusicManager musicManager;
	// Preference Manager has static functions so needs no object
	
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		// Set Inititial Slider values
		difficultySlider.value = PreferenceManager.getDifficulty();
		musicSlider.value = PreferenceManager.getVolume();
		sfxSlider.value = PreferenceManager.getSFX();
		_unsavedVolume();
	
	}
	
	// Update is called once per frame
	void Update () {
		//TODO Change MusicManager Volumes
		musicManager.setMusicVolume(musicSlider.value);
	}
	
	
	// Apply changes and return to Start
	public void SaveAndQuit(){
		PreferenceManager.setDifficulty(difficultySlider.value);
		PreferenceManager.setVolume(musicSlider.value);
		PreferenceManager.setSFX(sfxSlider.value);
		//TODO Update MusicManager Volume
		levelManager.LoadLevel("01a Main Menu");
	
	}
	
	
	// Reset values to previous
	public void QuitWithoutSave(){
		PreferenceManager.setDifficulty(difficulty);
		PreferenceManager.setVolume(music);
		PreferenceManager.setSFX(sfx);
		difficultySlider.value = PreferenceManager.getDifficulty();
		musicSlider.value = PreferenceManager.getVolume();
		sfxSlider.value = PreferenceManager.getSFX();
		levelManager.LoadLevel("01a Main Menu");

	}
	
	// Sets default values
	public void Defaults(){
		difficultySlider.value = 1;
		musicSlider.value = 0.5f;
		sfxSlider.value = 0.4f;
	}
	
	// Saves unsaved volume in case changes are not applied
	void _unsavedVolume(){
		difficulty = difficultySlider.value;
		music = musicSlider.value;
		sfx = sfxSlider.value;
	}
}
