using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Golem")
        {
            print("Collide!!!!!");
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 1000f, ForceMode.Impulse);
        }
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
