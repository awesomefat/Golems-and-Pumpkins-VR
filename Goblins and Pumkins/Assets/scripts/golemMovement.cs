//made change
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class golemMovement : MonoBehaviour {
    //set these in Unity
    //public SteamVR_TrackedObject leftController;
   // public SteamVR_TrackedObject rightController;

    public Hand leftHand;
    public Hand rightHand;

    //Need to extract the actual controller devices from the tracked objects
    private SteamVR_Controller.Device deviceL;
    private SteamVR_Controller.Device deviceR;

    private Rigidbody myBody;
    private float moveForce = 10f;

	// Use this for initialization
	void Awake () 
    {
        this.myBody = this.GetComponent<Rigidbody>();
        //this.deviceL = SteamVR_Controller.Input((int)this.leftController.index);
        //this.deviceR = SteamVR_Controller.Input((int)this.rightController.index);
    }


    // Update is called once per frame
    void Update()
    {
        this.deviceL = this.leftHand.controller;
        this.deviceR = this.rightHand.controller;

        float h = Input.GetAxis("Horizontal");
        this.myBody.velocity = new Vector3(-h * this.moveForce, 0f, 0f);

        if (deviceL.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Vector2 touchpad = (deviceL.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0));
            print("Pressing Touchpad " + touchpad.x);
            h = touchpad.x;
            this.myBody.velocity = new Vector3(-h * this.moveForce, 0f, 0f);
        }

        if(deviceR.GetHairTriggerDown())
        {
            this.myBody.AddForce(Vector3.up * 2000f, ForceMode.Impulse);
        }
    }
}
