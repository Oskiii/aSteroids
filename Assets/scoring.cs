using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoring : MonoBehaviour {

	public int score = 0;
	public int level;
	public int nextLevelScore;
	public static scoring current;
	public Text scoreText;

	void Awake (){
		current = this;
	}

	void Start (){
		scoreText.text = "Level: " + level + "\nScore: " + score;
	}

	public void AddPoints (int points) {
		score = score + points;
		print ("anal");

		if (score >= nextLevelScore) {
			print ("moi");
			level = level+ 1;
			nextLevelScore = score * 2;
			spawnAsteroids.current.spawnDelay = (10 - level) + 1/(Mathf.Pow(level, 2)); 
		}

		scoreText.text = "Level: " + level + "\nScore: " + score;
	}
}
