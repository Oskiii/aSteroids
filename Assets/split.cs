using UnityEngine;
using System.Collections;

public class split : MonoBehaviour {

	Rigidbody2D rib;
	public GameObject asteroid;

	void Start () {
		rib = GetComponent<Rigidbody2D>();
		rib.velocity = new Vector2 (Random.Range (-1f,1f), Random.Range(-1f,1f));
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "ammo") {
			GameObject asteroidShard = (GameObject) Instantiate (asteroid, transform.position, transform.rotation);
			asteroidShard.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range (-1f,1f), Random.Range(-1f,1f));
			rib.velocity = new Vector2(Random.Range (-1f,1f), Random.Range(-1f,1f));
			collider.gameObject.SetActive(false);



			gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x/2, gameObject.transform.localScale.y/2, gameObject.transform.localScale.z/2);
			asteroidShard.transform.localScale = new Vector3(asteroidShard.transform.localScale.x/2, asteroidShard.transform.localScale.y/2, asteroidShard.transform.localScale.z/2);

		}
	}

	void Update(){
		if (gameObject.transform.localScale.x < 0.05)
			Destroy (gameObject);
	}
}
