using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject ammo;
	private Rigidbody2D rib;
	private float lastFireTime = 0f;
	public float fireDelay = 0.5f;

	void Start (){
		rib = GetComponent<Rigidbody2D> ();
	}
	

	void Update (){
		if (Input.GetButtonDown ("Fire1") == true)
			FireBullet();

		if ((Input.GetButton ("Fire1") == true) && (lastFireTime + fireDelay < Time.time)){
			FireBullet ();
			lastFireTime = Time.time;
		}
		
	}

	void FireBullet (){
		GameObject bullet = ObjectPooler.current.GetPooledObject();
		if(bullet == null) return;
		
		bullet.gameObject.transform.position = transform.position;
		
		bullet.SetActive(true);
		bullet.GetComponent<Rigidbody2D> ().velocity = transform.up * 5;
	}
}
