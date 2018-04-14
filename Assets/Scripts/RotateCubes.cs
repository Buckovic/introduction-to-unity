using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCubes : MonoBehaviour {

    private GameObject holder; 
    private GameObject[] objArr = new GameObject[5];
    private Vector3 defPos = new Vector3 (0,0,0);

    // Use this for initialization
    void Start () {
        print("test");
        holder = GameObject.Find("CubeHolder");
        defPos = holder.transform.localPosition;
        for (int i = 0; i < objArr.Length; i++) {
            objArr[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objArr[i].transform.localScale = new Vector3 (5,5,5);
            objArr[i].transform.localPosition = holder.transform.localPosition;
            objArr[i].transform.Rotate(i, i, 0);
        }
    }

    // Current rotation
    float c_rot = 0;

    void Update () {
        c_rot += 0.05f;
        for (int i = 0; i < objArr.Length; i++) {
            objArr[i].transform.localPosition = new Vector3 (defPos.x+Mathf.Sin(c_rot)*2, defPos.y+Mathf.Cos(c_rot)*2, defPos.z);
            objArr[i].transform.Rotate((i+1)*0.1f, (i+1)*0.2f, (i+1)*0.3f);
        }

    }
}
