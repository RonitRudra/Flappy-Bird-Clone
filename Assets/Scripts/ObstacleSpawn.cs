using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour {
	#region Global Variables
	
	// Location of Opening
	private Vector3 placement;
	// Prefab to use
	public GameObject pipePrefab;
	// Velocity of approach
	public float velocity = 5;
	
	#endregion
	// Use this for initialization
	void Start () {
		// TODO Change invoke times according to difficulty
		// Call placePipe every x seconds
		InvokeRepeating("placePipe",3f,2.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void placePipe(){
		// New placement vector
		placement = new Vector3(0,Random.Range(-4f,0.5f),0);
		// Instantiate GameObject
		GameObject pipe = Instantiate(pipePrefab,placement,Quaternion.identity) as GameObject;
		// Maintain hierarchy by parenting to spawner
		pipe.transform.SetParent(transform);
		pipe.transform.position = new Vector3(transform.position.x,pipe.transform.position.y,pipe.transform.position.z);
		// give velocity to object
		pipe.rigidbody2D.velocity = new Vector3(-velocity,0,0);
	}
}
