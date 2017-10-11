using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {
    public Text score;
    public GameObject gameover;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(gm.gameover)
        {
            score.text = "Score : " + gm.score;
        }
        else
        {
            gameover.SetActive(true);
        }
	}
}
