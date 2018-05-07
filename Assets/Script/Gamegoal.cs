using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamegoal : MonoBehaviour {
	int Bcount=0;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		Bcount = osaifu.count;
	}
	void OnTriggerEnter (Collider hit){
		// 接触対象はPlayerタグですか？
		if (hit.gameObject.CompareTag ("Player")) {

			// このコンポーネントを持つGameObjectを破棄する
			Destroy(gameObject);
			//Debug.Log(Bcount);

		}
		if (Bcount == 0) {
			
		} else {


			// 現在のシーンを再読込する
			SceneManager.LoadScene("Scene1");
		}


}
}