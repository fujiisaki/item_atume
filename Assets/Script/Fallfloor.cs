using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallfloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("Player")){
			Invoke("Fall",7);
		}
	}
			void Fall(){
		GetComponent<Rigidbody> ().isKinematic = false;
	}
}
