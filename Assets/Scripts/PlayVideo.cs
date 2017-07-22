using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayVideo : MonoBehaviour {

		public string nextLevel; 								//Name of the next level
		public MovieTexture movie; 								//Source of the video clip
		public float waitTime = 20f; 							//Default time of video clip
		private float timer = 0; 								//Timer for detecting end of video


		void Start () 
		{
		// Set up the reference.
		GetComponent<RawImage>().texture = movie as MovieTexture; 	
		movie.Play();											//Play video
			Time.timeScale = 1f; 
			Cursor.visible = false; 							//Disable coursor when playing video
		}

		void Update()
		{
			timer += Time.deltaTime;

		if ((int)timer >= waitTime) 
		{ 														//If video ends change coursor to visible again and move to next scene.
			Cursor.visible = true;
			Initiate.Fade (nextLevel, Color.black, 10.0f);
		}
		}

	}