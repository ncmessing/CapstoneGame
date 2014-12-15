using UnityEngine;
using System.Collections;

public class BoomerZombieHit : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			PlayerMovement player = other.GetComponentInParent<PlayerMovement>();
			player.Damage(.5);
		}	
	}
}
