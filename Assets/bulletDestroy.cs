using UnityEngine;
using System.Collections;

public class bulletDestroy : MonoBehaviour {

	void OnEnable(){
		Invoke ("Destroy", 5f);
	}

	void Destroy(){
		gameObject.SetActive (false);
	}

	void OnDisable(){
		CancelInvoke ();
	}

	void Update(){
		if((Mathf.Abs(transform.position.x) > 7) || (Mathf.Abs(transform.position.y) > 5.2)){
			Destroy ();
		}

	}
}
