using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_gimikku : MonoBehaviour {
	public  Rigidbody rb;
	private Vector3 Pos;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Pos = transform.position;
	}
	void FixedUpdate() {
		this.gameObject.transform.position=new Vector3 (Pos.x+ Mathf.PingPong (Time.time, 2), Pos.y , Pos.z);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
