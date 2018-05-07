using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fieldbutton : MonoBehaviour {


		public Text CountLabel;
		float Count=0.0f;
		public float timer  ;
		public bool button2=false;
		public Text timerLabel;
		public GameObject Button2;
	bool push=false;
		// Use this for initialization
		void Start () {
		
		}
	public void PushDown(){
		push = true;

	}
	public void PushUp(){
		push = false;
	}

		// Update is called once per frame
		void Update () {
		if (push) {
			GO();
		}
		if (timer >= 0.0f) {
			timer -= Time.deltaTime;

		} else {
			Destroy(Button2);
		}

			timerLabel.text=timer.ToString("f1");
			CountLabel.text=Count.ToString("f0");


		}

	void OnCollisionEnter(Collision collision){
		timer = 5.0f;

		if (collision.gameObject.CompareTag ("Player")) {
			Button2.SetActive (true);
		}

	}
	public void GO(){
		Count = Count + 1;
		push = false;}
		
		public void button(){
			button2=true;
		}

	}
