using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    public Rigidbody2D rg;
    public bool jump = true;
    public bool stand = false;
    public static bool walk = false;
    public bool live = true;
    public int face = 1;
    public float step = 0.1f;
    public float high = 300f;
    
	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(gm.gameover)
        {
            if (Input.GetKey(KeyCode.A))
            {
                //animator.SetBool("iswalking", true);
                walk = true;
                face = 1;
                fun_walk();
            }
            else if (Input.GetKey(KeyCode.D))
            {
                //animator.SetBool("iswalking", true);
                walk = true;
                face = -1;
                fun_walk();
            }
            else
            {
                // animator.SetBool("iswalking", false);
                walk = false;
            }
            if (Input.GetKeyDown(KeyCode.W) && !jump)
            {
                //Debug.Log(high);
                fun_jump();
            }
            if (face == -1)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (face == 1)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }
		
	}
    void fun_walk()
    {
       
        transform.position += Vector3.left * step * face;
    }
    void fun_jump()
    {
        jump = true;
        rg.AddForce(Vector2.up * high);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump = false;
       /* if(collision.gameObject.tag=="enemy")
        {
            gm.gameover = false;
        }*/
    }
}
