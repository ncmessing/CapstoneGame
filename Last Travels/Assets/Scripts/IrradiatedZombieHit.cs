using UnityEngine;
using System.Collections;

public class IrradiatedZombieHit : MonoBehaviour {
	private PlayerMovement player;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			player = other.GetComponentInParent<PlayerMovement>();
			InvokeRepeating("DamagePlayer", 0, 1);
			WaitForTime(5);
			CancelInvoke();
		}	
	}

	IEnumerator WaitForTime(int time)
	{
		yield return new WaitForSeconds (5);
	}

	void DamagePlayer()
	{
		Debug.Log ("Damaging player");
		player.Damage(.1);
	}
}
