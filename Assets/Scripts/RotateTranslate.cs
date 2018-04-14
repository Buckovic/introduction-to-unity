using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTranslate : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(1, 1, 0);
        transform.Translate(0.01f, 0, 0);

    }
}
