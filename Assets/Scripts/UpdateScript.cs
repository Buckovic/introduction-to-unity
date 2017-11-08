using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple motion script that alters the object orientation

public class UpdateScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// Add one degree every frame
		transform.Rotate (new Vector3 (0, 1, 0));
	}
}
