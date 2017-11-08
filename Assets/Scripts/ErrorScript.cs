using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// In this example we show how to invoke a coroutine and
// continue executing the function in parallel.
// It is used to indicate what an error looks like in 
// the console, and how to use stack trace.

public class ErrorScript : MonoBehaviour {

	private IEnumerator coroutine;

	// Use this for initialization
	void Start () {
		// Start function WaitAndError as a coroutine.
		coroutine = WaitAndError(20.0f);
		StartCoroutine(coroutine);
	}

	private IEnumerator WaitAndError(float waitTime)
	{		
			yield return new WaitForSeconds(waitTime);
			Debug.LogError("arg arg meh " + Time.time);
	}
}
