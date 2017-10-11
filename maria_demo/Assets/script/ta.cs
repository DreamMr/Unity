using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ta : MonoBehaviour {
   // public Transform trans;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // transform.position = new Vector3(trans.position.x, trans.position.y-0.068f, trans.position.z);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("enemydie");
            Destroy(collision.gameObject);
        }
    }
}
