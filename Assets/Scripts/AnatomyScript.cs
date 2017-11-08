using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnatomyScript : MonoBehaviour {

	bool awake, start, update, fixedupdate, lateupdate, ongui, 
	ondisable, onenable = false;

	// Awake is called when the script instance is being loaded.
	void Awake(){
		if (!awake) {
			Debug.LogWarning (this);
			awake = true;
		}
	}

	// Start is called on the frame when a script is enabled just 
	// before any of the Update methods is called the first time.
	void Start () {
		if (!start) {
			Debug.LogWarning (this);
			start = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!update) {
			Debug.LogWarning (this);
			update = true;
		}
	}

	// This function is called every fixed framerate frame, if the 
	// MonoBehaviour is enabled. Good for physics stuff.
	void FixedUpdate(){
		if (!fixedupdate) {
			Debug.LogWarning (this);
			fixedupdate = true;
		}
	}

	// LateUpdate is called every frame, if the Behaviour is enabled.
	void LateUpdate(){
		if (!lateupdate) {
			Debug.LogWarning (this);
			lateupdate = true;
		}
	}

	// OnGUI is called for rendering and handling GUI events.
	void OnGUI(){
		if (!ongui) {
			Debug.LogWarning (this);
			ongui = true;
		}
	}

	// This function is called when the behaviour becomes disabled () or inactive.
	void OnDisable(){
		if (!ondisable) {
			Debug.LogWarning (this);
			ondisable = true;
		}
	}


	// This function is called when the object becomes enabled and active.
	void OnEnabled(){
		if (!onenable) {
			Debug.LogWarning (this);
			onenable = true;
		}
	}
}
