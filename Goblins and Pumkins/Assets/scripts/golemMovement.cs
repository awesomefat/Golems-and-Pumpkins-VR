using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golemMovement : MonoBehaviour {

    private Rigidbody myBody;
    private float moveForce = 10f;

	// Use this for initialization
	void Awake () 
    {
        this.myBody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        this.myBody.velocity = new Vector3(-h * this.moveForce, 0f, 0f);
	}
}
