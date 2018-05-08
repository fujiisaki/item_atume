using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Startbutton(){

	
	// 現在のシーンを再読込する
	SceneManager.LoadScene("Scene1_1");

	}
	public void level1(){


		// 現在のシーンを再読込する
		SceneManager.LoadScene("Scene1");

	}
	public void level2(){


		// 現在のシーンを再読込する
		SceneManager.LoadScene("Scene1_2");

	}

}
