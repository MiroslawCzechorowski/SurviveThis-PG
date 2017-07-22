using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	Text text;	
	string level = "Lvl1Failed"; 								// Default load game over scene
	float timeLeft = 60.0f;										// 60s for player to find trigger and finish lvl


	// If player enters trigger... 
	void OnTriggerEnter(Collider other)
	{
		//change next scene to next lvl
		level = "Lvl1Success";
	}

	// If player exits trigger... 
	void OnTriggerExit(Collider other)
	{
		//...change next scene to game over
		level = "Lvl1Failed";
	}
		
	void Awake ()
	{
		// Set up the reference.
		text = GameObject.Find("Time").GetComponent<Text>(); 	
	}
		
	// Update is called once per frame
	void Update () 
	{
		timeLeft -= Time.deltaTime; 							//Decrease time left
		text.text = "TIME: " + timeLeft.ToString("0.0"); 		//Change time at UI
		//If no time left...
		if ( timeLeft < 0 ) 									
		{
			// ...than change scene
			Initiate.Fade (level, Color.black, 10.0f);
			//SceneManager.LoadScene (3);
		}
	}

}
