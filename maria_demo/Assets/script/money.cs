﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if(collision.gameObject.tag=="Player")
         {
             //Debug.Log("+1");
             gm.score += 1;
             Destroy(this.gameObject);
         }
     }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log("+1");
            gm.score += 1;
            Destroy(this.gameObject);
        }
    }
}
