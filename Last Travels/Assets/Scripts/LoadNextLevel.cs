using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "Player")
			Application.LoadLevel("Level2");
	}
}
