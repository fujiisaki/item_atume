using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseRun : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Animator anim = GetComponent<Animator>();
		if(Input.GetKey("up"))
		{
			transform.position += transform.forward * 0.2f;
			anim.SetBool("is_running", true);
		}
		else
		{
			anim.SetBool("is_running", false);
		}

		if (Input.GetKey("right"))
		{
			transform.Rotate(0,2,0);
		}

		if (Input.GetKey("left"))
		{
			transform.Rotate(0, -2, 0);
		}
	}
}
