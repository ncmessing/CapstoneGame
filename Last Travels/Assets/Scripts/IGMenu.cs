using UnityEngine;
using System.Collections;

public class IGMenu : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit ();
	
	}
}
}
