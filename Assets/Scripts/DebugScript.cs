using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scripts shows how to post custom messages to the console.
// Also simple example of plumbing together events in inspector
// that change a data model via a method/function.

public class DebugScript : MonoBehaviour
{

	int numOfClicks = 0;

	public void Clicked ()
	{
		numOfClicks++;
		Debug.Log ("Clicked " + gameObject.name + " " + numOfClicks + " times.");
//		Same thing but different 
//		Debug.LogFormat("Clicked {0} {1} times.",gameObject.name,numOfClicks);
	}
}
