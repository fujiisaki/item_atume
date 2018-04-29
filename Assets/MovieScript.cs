    using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityStandardAssets.CrossPlatformInput;
	using UnityEngine.AI;

	public class MovieScript : MonoBehaviour {
		

		NavMeshAgent agent = null;

		void Start () {
			agent = GetComponent<NavMeshAgent> ();
		}

		// Update is called once per frame
		void Update () {
			// 入力を取得
			
			var v1 = CrossPlatformInputManager.GetAxis ("Vertical1");
			var h1 = CrossPlatformInputManager.GetAxis ("Horizontal1");

			// スティックが倒れていれば、移動
			
			// スティックが倒れていれば、倒れている方向を向く
			if( h1 != 0 || v1 != 0){
				var direction = new Vector3 (h1, 0, v1);
				transform.localRotation = Quaternion.LookRotation (direction);
			}
		}
	}