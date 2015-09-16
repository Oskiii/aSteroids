using UnityEngine;
using System.Collections;

public class killShip : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider){
		if (collider.tag == "asteroid") {
			scoring.current.scoreText.text = "You died.";

		}
	}
}
