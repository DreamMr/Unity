using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calum : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 30f);
	}
    public float speed = 2f;
	// Update is called once per frame
	void Update () {
        if(gm.islife)
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
	}
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            //Debug.Log("+1");
            gm.score += 1;
        }
    }
}
