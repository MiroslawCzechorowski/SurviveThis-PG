using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour {


	public void Quit (){
		#if UNITY_EDITOR 
		UnityEditor.EditorApplication.isPlaying=false; 		//If you are using unity_editor exit from playing mode
		#else
		Application.Quit(); 								//If you use appication - exit from it.
		#endif
	}
}
