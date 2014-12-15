using UnityEngine;
using System.Collections;

public class SoldierZombieHit : MonoBehaviour {
	private PlayerMovement player;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			player = other.GetComponentInParent<PlayerMovement>();
			InvokeRepeating("DamagePlayer", 0, .5F);
		}	
	}
	
	void DamagePlayer()
	{
		player.Damage (.25);
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			CancelInvoke();
	}
}
