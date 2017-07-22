using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour {

															//Resume game after pause
	public void resumeGame()
	{
		Time.timeScale = 1.0f;
	}
}
