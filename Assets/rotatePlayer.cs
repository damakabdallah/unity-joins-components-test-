using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlayer : MonoBehaviour {
    public GameObject player;
    public ConstantForce2D CF2D;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        CF2D = player.GetComponent<ConstantForce2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x > -1 && player.transform.position.x < 1 && player.transform.position.y > -1 && player.transform.position.y < 1)
            CF2D.torque = 6500;
        else
            CF2D.torque = 0;
        
	}
}
