using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
	
	bool Paused = false;
	bool isShowing = false;
	public GameObject menu;


	void Update () {
		if (Input.GetKeyDown ("escape")) {
			isShowing = !isShowing;
			menu.SetActive(isShowing);					//Show/Hide menu panel when ESC pressed
			if(Paused == true){
				Time.timeScale = 1.0f; 					//Disable pause
				Paused = false;
			} else {
				Time.timeScale = 0.0f; 					//Pause
				Paused = true;
			}
		}
	}


	public void Resume(){
		Time.timeScale = 1.0f; 							//Disable pause
	}
}    