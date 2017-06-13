using UnityEngine;
using System.Collections;

public class collisionDetect : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider){
		if(name=="Left"){
			Destroy(collider.transform.parent.gameObject);
		}
	}
}
