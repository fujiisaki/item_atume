using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class osaifu : MonoBehaviour {
	public static int count;
	public Text text;
	// Use this for initialization
	void Start () {
		count = 4;

		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "残りのアイテム数"+"  :  "+count.ToString()+"こ";
	}
	void OnTriggerEnter (Collider hit){
		// 接触対象はPlayerタグですか？
		if (hit.gameObject.CompareTag ("item")) {

			// このコンポーネントを持つGameObjectを破棄する
			count=count-1;

		}

}

}