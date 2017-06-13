using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	//Attach to 3D Quad with texture set to repeat
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2(Time.time*speed,0f);
		renderer.material.mainTextureOffset = offset;
	}
}
