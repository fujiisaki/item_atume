//アニメーション
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.AI;
using UnityEngine.UI;


public class HorseRun : MonoBehaviour {
	//NavMeshAgent agent = null;
	bool push=false;

	private Animator anim;

	// Use this for initialization
	void Start () {
		//agent = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void PushDown(){
		push = true;

	}
	public void PushUp(){
		push = false;
	}

	void Update ()
	{
		if (push) {
			GoButton ();
		} else {
			anim.SetBool ("is_running", false);
			//anim.SetBool ("Idle", true);
		}
	
		var v2 = CrossPlatformInputManager.GetAxis ("Vertical");
		var h2 = CrossPlatformInputManager.GetAxis ("Horizontal");
		 


		if (h2 != 0 || v2 != 0) {
			var direction = new Vector3 (h2, 0, v2);
			transform.localRotation = Quaternion.LookRotation (direction);
		}
	}
	public void GoButton(){
		
		anim.SetBool ("is_running", true);
		transform.position += transform.forward * 0.2f;

	}

	}



	
	

