using UnityEngine;
using System.Collections;

public class spawnAsteroids : MonoBehaviour {
	
	public int amount;
	private float lastSpawn;
	public float spawnDelay;

	void Start () {
		for (int i = 0; i < amount; i++){
			SpawnAsteroid();
		}
		lastSpawn = Time.time;
	}

	void Update () {
		if (Time.time > lastSpawn + spawnDelay) {
			SpawnAsteroid ();
			lastSpawn = Time.time;
		}
		
	}

	void SpawnAsteroid(){
		Instantiate (Resources.Load ("asteroid", typeof(GameObject)) as GameObject, new Vector2 (Random.Range (-7, 7), Random.Range (-5, 5)), Quaternion.identity);
	}
}
