using UnityEngine;
using System.Collections;

public class resetpos : MonoBehaviour {

	public float limitx = 7.8f;
	public float limity = 5.2f;


	void Update () {

		if (transform.position.x > limitx) {
			transform.position = new Vector2(-limitx + 0.01f, transform.position.y);
		}

		if (transform.position.x < -limitx) {
			transform.position = new Vector2(limitx - 0.01f, transform.position.y);
		}

		if (transform.position.y > limity) {
			transform.position = new Vector2(transform.position.x, -limity + 0.01f);
		}
		
		if (transform.position.y < -limity) {
			transform.position = new Vector2(transform.position.x, limity - 0.01f);
		}


	}
}
