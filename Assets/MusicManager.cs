using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	// Persistent GameObject throughout all scenes
	
	AudioSource audioSource;
	public AudioClip[] LevelMusic;
	
	// Do stuff before calling Start
	void Awake(){
		// Do not destroy this object on loading new scene 
		DontDestroyOnLoad(gameObject);
	}
	// Use this for initialization
	void Start () {
	audioSource = GetComponent<AudioSource>();
	audioSource.volume = PreferenceManager.getVolume();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Method called on Each Scene Load
	// level is an index of the level
	void OnLevelWasLoaded(int level){
		// set clip for current level
		AudioClip music_current = LevelMusic[level];
		// If clip present then play on loop
		// If absent then previous clip keeps playing
		if(music_current){
			audioSource.clip = music_current;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	
	public void setMusicVolume(float volume){
		audioSource.volume = volume;
	}
}
