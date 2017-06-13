using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// Declare Rigidbody2D variable for storing child component
	private Rigidbody2D bird;
	// Vertical Velocity
	private float velocity = 4;
	// Use this for initialization
	void Start () {
		// Find Rigidbody2D component in child
		bird = gameObject.GetComponentInChildren<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
		// Give velocity in Y direction on pressing Space
		if(Input.GetKeyDown(KeyCode.Space)){
			bird.velocity = new Vector3(0,velocity,0);
		}
	}
	
}
