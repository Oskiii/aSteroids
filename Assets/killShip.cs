using UnityEngine;
using System.Collections;

public class killShip : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider){
		if (collider.tag == "asteroid") {
			print ("hi");
			scoring.current.lives = scoring.current.lives - 1;

			if (scoring.current.lives <= 0)
				Application.LoadLevel("menu");


		}
	}
}
