using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float g_x;
    public float g_y;
    private float g_z;

    // Use this for initialization
    void Start()
    {
        g_x = 0.0f;
        g_y = 1.0f;
        g_z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(g_x, g_y, g_z);
    }
}
