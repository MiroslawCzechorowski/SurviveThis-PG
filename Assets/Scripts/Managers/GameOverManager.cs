using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameOverManager : MonoBehaviour
{
	public PlayerHealth playerHealth;    							   // Reference to the player's health.

	void Update ()
	{
		// If the player has run out of health...
		if(playerHealth.currentHealth <= 0)
		{
			// ... tell the animator the game is over.
			string KEY_HIGH_SCORE = "highscore";						// To save highscore
			PlayerPrefs.SetInt (KEY_HIGH_SCORE, 0);
			int currentHighScore = PlayerPrefs.GetInt(KEY_HIGH_SCORE); // If no score was saved corresponding to that key then it will return 0
			if (currentHighScore < ScoreManager.score) 					// if stored score is less than the current score
				PlayerPrefs.SetInt(KEY_HIGH_SCORE, ScoreManager.score);
			Initiate.Fade ("GameOverScene", Color.black, 10.0f);
			//SceneManager.LoadScene (2);
		}
	}
}