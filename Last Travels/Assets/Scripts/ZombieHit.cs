using UnityEngine;
using System.Collections;

public class ZombieHit : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("Hitting player");
		}	
	}
}