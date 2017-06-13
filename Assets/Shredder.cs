using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		// Destroy pipe on exiting scene
		// Only pipe is capable of colliding with shredder
		Destroy(collider.transform.parent.gameObject);
	}
}
