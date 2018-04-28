using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class usagiRun : MonoBehaviour{
	// Use this for initialization
	Animator anim;
	void Start () {
		anim = gameObject.GetComponent<Animator> ();

		anim.SetInteger ("AnimPar", 0);
	}
	
	// Update is called once per frame
	void Update (){
		if (Input.GetKey ("up")) {
			anim.SetInteger ("AnimPar", 1);
			transform.position += transform.forward * 0.2f;

		} //else {
			//anim.SetInteger("AnimPar", 0);
		//}

	}
	
}
