using UnityEngine;
using System.Collections;

public class spawnAsteroids : MonoBehaviour {

	public static spawnAsteroids current;

	public int amount;
	private float lastSpawn;
	public float spawnDelay;
	public GameObject asteroid;
	public GameObject player;

	void Awake ()
	{
		current = this;
	}

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
		Vector2 randomPos = new Vector2 (Random.Range (-7, 7), Random.Range (-5, 5));
		float randomScale = Random.Range (0.2f, 0.6f);
		int spawnDistance = 1;

		if ((Mathf.Abs(randomPos.x - player.transform.position.x) < spawnDistance) || 
		     (Mathf.Abs(randomPos.y - player.transform.position.y) < spawnDistance)){


			SpawnAsteroid ();
		} else {
			GameObject obj = (GameObject) Instantiate (asteroid, randomPos, Quaternion.identity);
			obj.transform.localScale = new Vector2(randomScale, randomScale);
		}
	}
}
