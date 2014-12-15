using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public float barDisplay;
	public Vector2 pos = new Vector2(20,40);
	public Vector2 size = new Vector2(60,20);
	public Texture emptyTex;
	public Texture fullTex;
	public double tempTest;
	public double originalHealth;


	void OnGUI()
	{
				//the GUI box is initialized to the fullTex texture (green rectangle)
				GUI.BeginGroup (new Rect (pos.x, pos.y, size.x, size.y));
				GUI.Box (new Rect (0, 0, size.x, size.y), fullTex);
		
				//emptyTex, the red rectangle will start to fill the GUI box
				GUI.BeginGroup (new Rect (0, 0, size.x * barDisplay, size.y));
				GUI.Box (new Rect (0, 0, size.x, size.y), emptyTex);
				GUI.EndGroup ();
				GUI.EndGroup ();

	}


	void Start() {
		tempTest = PlayerMovement.startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		//get the value of player's health
		tempTest = PlayerMovement.startingHealth;
		//barDisplay, used to render the proportion of the box colored in red, caculated as a value from 0.0 to 1
		barDisplay = (float)(1 - (tempTest / originalHealth));


	}
}
