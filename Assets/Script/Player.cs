//馬の動き
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


float speed =3.0f;

// Use this for initialization
void Start () {

}

// Update is called once per frame
void Update () {
	if (Input.GetKey ("up")) {//下矢印を押せば、、、
		transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
		Debug.Log ("GO");
	}


	if (Input.GetKey ("right")) {//左矢印を押せば、、、
		transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
		Debug.Log ("right");
	}
		if (Input.GetKey ("left")) {//右矢印を押せば、、、
		transform.position += new Vector3 ( speed * Time.deltaTime,0,0);
		Debug.Log ("left");
	}

	if (Input.GetKey ("down")) {//上矢印を押せば、、、
		transform.position += new Vector3 (0, 0, speed * Time.deltaTime);
		Debug.Log ("Buck");
	}


}
}