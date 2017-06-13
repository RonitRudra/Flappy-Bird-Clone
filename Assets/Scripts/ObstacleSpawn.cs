using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour {
	private Vector3 placement;
	public GameObject pipePrefab;
	public float velocity = 5;
	// Use this for initialization
	void Start () {
		InvokeRepeating("placePipe",5,5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void placePipe(){
		placement = new Vector3(0,Random.Range(-4f,0.5f),0);
		GameObject pipe = Instantiate(pipePrefab,placement,Quaternion.identity) as GameObject;
		pipe.transform.SetParent(transform);
		pipe.transform.position = transform.position;
		pipe.rigidbody2D.velocity = new Vector3(-velocity,0,0);
	}
}
