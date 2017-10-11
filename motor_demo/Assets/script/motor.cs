using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motor : MonoBehaviour {
    public WheelJoint2D right;
    public WheelJoint2D left;
    public float speed = 2500f;
    public float rotate = 500f;
    public JointMotor2D car;
    public SpriteRenderer spr;
    public bool ischange=false;
    public Rigidbody2D rg;
	// Use this for initialization
	void Start () {
        rg=GetComponent<Rigidbody2D>();
        car.maxMotorTorque = 10000;//若不设这个值，他的上限为0，无法跑动
        spr = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frameVertical
    void Update () {
        car.motorSpeed = -speed*Input.GetAxis("Vertical");
        right.motor = car;
        left.motor = car;
        rg.AddTorque(rotate * Input.GetAxis("Horizontal") * Time.deltaTime);
        if(Input.GetKey(KeyCode.A))
        {
           // Texture2D texture2d = (Texture2D)Resources.Load("01");//更换为红色主题英雄角色图片  
           // Sprite sp = Sprite.Create(texture2d, new Rect(0.0f,0.0f,texture2d.width,texture2d.height), new Vector2(0.5f, 0.5f));//注意居中显示采用0.5f值  
           // spr.sprite = sp;
        }
	}
}
//Is Trigger为否时，自身和被碰撞物体会触发OnCollision函数不会触发OnTrigger函数，系统在OnCollision函数触发时进行物理特性的模拟，例如物体碰到地面上会停下来，而不是直接穿透地面。

//当Is Trigger被勾选时，自身和被碰撞到物体都会触发OnTrigger函数，无论被碰撞的物体是否勾选了Is Trigger。

//也就是说OnTrigger与OnCollision只能触发一种， 因此Is Trigger被勾选时OnCollision不被触发，也就不进行物理特性的模拟，所以对于物体间可以相互穿透又可以进行碰撞检测的需求可以选择勾选Is Trigger来实现
