using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {

    GameObject cubeA; // The found object
    public GameObject cubeB; // Editor configured object

    void Start()
    {
        cubeA = GameObject.Find("Cube_A");
    }

    void Update()
    {
        cubeA.transform.Rotate(0, 1, 0);
        cubeB.transform.Rotate(0, -1, 0);
    }
}
