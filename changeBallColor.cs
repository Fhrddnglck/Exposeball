using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeBallColor : MonoBehaviour {
    public GameObject[] healthBall;
    
    // Use this for initialization
    void Start() {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(ball.atilanTop==1)
        {
            healthBall[2].GetComponent<Renderer>().material.color = Color.white;
        }
        if(ball.atilanTop == 2)
        {
            healthBall[2].GetComponent<Renderer>().material.color = Color.white;
            healthBall[1].GetComponent<Renderer>().material.color = Color.white;
        }
        if(ball.atilanTop ==3)
        {
            healthBall[2].GetComponent<Renderer>().material.color = Color.white;
            healthBall[1].GetComponent<Renderer>().material.color = Color.white;
            healthBall[0].GetComponent<Renderer>().material.color = Color.white;
        }
	}
    
}
