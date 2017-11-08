using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Changing an objects cubes colour at the start of a scene.
// GetComponent method is very useful.

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Material m = GetComponent<Renderer> ().material;
		m.color = Color.red;
	}
}
