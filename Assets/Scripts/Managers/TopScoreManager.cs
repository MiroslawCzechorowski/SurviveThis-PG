using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TopScoreManager : MonoBehaviour
{
	public static int top_score;        							// The player's score.	
	Text text;                     									// Reference to the Text component.


	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		string KEY_HIGH_SCORE = "keyhighscore"; 					// Default settings
		// To save highscore
		int currentHighScore = PlayerPrefs.GetInt(KEY_HIGH_SCORE); 	// If no score was saved corresponding to that key then it will return 0
		// Reset the score.
		top_score = currentHighScore;
		Debug.Log ("SCORE_TOP:" + top_score);
	}
}