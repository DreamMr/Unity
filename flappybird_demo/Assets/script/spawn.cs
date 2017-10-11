using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    public GameObject calum;
    public float cold = 2f;
    public float next;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time>next && gm.islife)
        {
            next +=cold;
            Vector3 v = transform.position;
            float tmpx = 0;
            tmpx = Random.Range(-2.5f, 2.5f);
            v.y += tmpx;
            Instantiate(calum, v, transform.rotation);
        }
	}
}
