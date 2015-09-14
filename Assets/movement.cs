using UnityEngine;
using System.Collections;


public class movement : MonoBehaviour {

	private Rigidbody2D rib;
	public GameObject ammo;
	public float maxSpeed;
	public float maxRot;

	void Start (){
		rib = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate (){
		if (Input.GetAxisRaw ("Vertical") >= 0.01)
			rib.AddRelativeForce( new Vector2 (0f, 2f), 0);

		if (Input.GetAxisRaw ("Horizontal") <= -0.01)
			rib.AddTorque (6f);

		if (Input.GetAxisRaw ("Horizontal") >= 0.01)
			rib.AddTorque (-6f);

		if (rib.velocity.x > maxSpeed) {
			rib.velocity = new Vector2 (maxSpeed, rib.velocity.y);
		} else if (rib.velocity.x < -maxSpeed) {
			rib.velocity = new Vector2 (-maxSpeed, rib.velocity.y);
		} else if (rib.velocity.y > maxSpeed) {
			rib.velocity = new Vector2 (rib.velocity.x, maxSpeed);
		} else if (rib.velocity.y < -maxSpeed) {
			rib.velocity = new Vector2 (rib.velocity.x, -maxSpeed);
		}

		if (rib.angularVelocity > maxRot) {
			rib.angularVelocity = maxRot;
		} else if (rib.angularVelocity < -maxRot) {
			rib.angularVelocity = -maxRot;
		}


	}

	void Update (){
		if (Input.GetButtonDown ("Fire1") == true) {
			GameObject bullet = (GameObject)Instantiate (ammo, transform.position, transform.rotation);
			bullet.GetComponent<Rigidbody2D> ().AddRelativeForce ((rib.velocity + new Vector2 (0f, 200f)), 0);
			Destroy(bullet, 5f);
		}
	}
}
