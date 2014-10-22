using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	//public Texture backgroundTexture;
	public float guiPlacementX_start=0.9f; 
	public float guiPlacementY_start=0.8f;
	public float guiPlacementX_options=0.9f;
	public float guiPlacementY_options=0.9f;
	//boolean to control music replay
	//public bool hasStarted = false;
	
	//public AudioClip menuMusic;
	
	
	void OnGUI()
	{
		//Display background texture
		//GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		//Display buttons
		if (GUI.Button (new Rect (Screen.width * guiPlacementX_start, Screen.height * guiPlacementY_start, 
		                          Screen.width * 0.1f, Screen.height * .1f), "Start")) {
			/*if(!hasStarted)
			{
				
				audio.PlayOneShot(menuMusic);
				hasStarted = true;
			}*/
			Application.LoadLevel("DemoLevel");
			
		}
		
		if (GUI.Button (new Rect (Screen.width * guiPlacementX_options, Screen.height * guiPlacementY_options, 
		                          Screen.width * 0.1f, Screen.height * .1f), "Quit")) {
			Application.Quit ();
		}
	}
}
