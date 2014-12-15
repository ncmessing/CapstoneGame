	using UnityEngine;
	using System.Collections;
	
	public class IGMenu : MonoBehaviour {
		
		private bool GUIenabled = false;
		public float guiPlacementX_level1=0.9f; 
		public float guiPlacementY_level1=0.5f;
		public float guiPlacementX_level2=0.9f; 
		public float guiPlacementY_level2=0.6f;
		public float guiPlacementX_level3=0.9f; 
		public float guiPlacementY_level3=0.7f;
		public float guiPlacementX_start=0.9f; 
		public float guiPlacementY_start=0.8f;
		public float guiPlacementX_options=0.9f;
		public float guiPlacementY_options=0.9f;
		public string inventory_text="Inventory!";
		
		
		void OnGUI()
		{
			
			if(GUIenabled)
			{
				if (GUI.Button (new Rect (Screen.width * guiPlacementX_level1, Screen.height * guiPlacementY_level1, 
				                          Screen.width * 0.1f, Screen.height * .1f), "Load Level 1")) {
					Application.LoadLevel("DemoLevel");
					
				}
				if (GUI.Button (new Rect (Screen.width * guiPlacementX_level2, Screen.height * guiPlacementY_level2, 
				                          Screen.width * 0.1f, Screen.height * .1f), "Load Level 2")) {
					Application.LoadLevel("Level2");
					
				}
				
				if (GUI.Button (new Rect (Screen.width * guiPlacementX_level3, Screen.height * guiPlacementY_level3, 
				                          Screen.width * 0.1f, Screen.height * .1f), "Load Level 3")) {
					Application.LoadLevel("Level3");
					
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

