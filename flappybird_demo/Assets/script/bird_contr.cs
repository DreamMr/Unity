using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_contr : MonoBehaviour {
    public Rigidbody2D rg;
    public float speed = 200f;
	// Use this for initialization
	void Start () {
        rg = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
        {
            rg.AddForce(Vector2.up * speed);
        }
	}
   
}
