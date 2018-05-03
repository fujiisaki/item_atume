using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranporinn : MonoBehaviour {
	public float jumpHeight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider c) {
		if (c.gameObject.tag == "Horse") {
			Rigidbody rb = c.GetComponent<Rigidbody>();
			rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
		}
}

}