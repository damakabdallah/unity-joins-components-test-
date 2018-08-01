using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDirection : MonoBehaviour {
    public SurfaceEffector2D SE2D;
	// Use this for initialization
	void Start () {
        SE2D = this.GetComponent<SurfaceEffector2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            SE2D.speed *= -1;
	}
}
