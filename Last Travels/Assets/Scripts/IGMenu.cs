using UnityEngine;
using System.Collections;

public class IGMenu : MonoBehaviour {

	private bool GUIenabled = false;
	public float guiPlacementX_inventory=0.9f; 
	public float guiPlacementY_inventory=0.7f;
	public float guiPlacementX_start=0.9f; 
	public float guiPlacementY_start=0.8f;
	public float guiPlacementX_options=0.9f;
	public float guiPlacementY_options=0.9f;
	public string inventory_text="Inventory!";


	void OnGUI()
	{

		if(GUIenabled)
		{

				if (GUI.Button (new Rect (Screen.width * guiPlacementX_inventory, Screen.height * guiPlacementY_inventory, 
				                          Screen.width * 0.1f, Screen.height * .1f), "Inventory")) {
				inventory_text = GUI.TextArea (new Rect (5, 5, 200, 300), inventory_text, 200);
					
				}
			if (GUI.Button (new Rect (Screen.width * guiPlacementX_start, Screen.height * guiPlacementY_start, 
			                          Screen.width * 0.1f, Screen.height * .1f), "Quit to Menu")) {
				Application.LoadLevel("MainMenu");
		}
		if (GUI.Button (new Rect (Screen.width * guiPlacementX_options, Screen.height * guiPlacementY_options, 
			                          Screen.width * 0.1f, Screen.height * .1f), "Quit Game")) {
				Application.Quit ();
			}
	}
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit ();
		}

		if (Input.GetKey (KeyCode.Delete))
		{
			Application.LoadLevel (1);
		}

		if (Input.GetKeyDown (KeyCode.F1)) 
		{
			GUIenabled = !GUIenabled;
		}
	}
}
