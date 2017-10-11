using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
    public Vector3 v;
    public GameObject car;
	// Use this for initialization
	void Start () {
        v = car.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        v = car.transform.position;
        v.z -= 10;
        transform.position = v;
	}
}
