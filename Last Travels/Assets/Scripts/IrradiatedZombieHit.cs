using UnityEngine;
using System.Collections;

public class IrradiatedZombieHit : MonoBehaviour {
	private PlayerMovement player;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			player = other.GetComponentInParent<PlayerMovement>();
			DamagePlayer(5, 1);
		}	
	}

	IEnumerator DamagePlayer(int time, int interval)
	{
		int count = time / interval;
		Debug.Log (count);
		while (count > 0)
		{
			Debug.Log ("Player damaged");
			player.Damage(.1);
			yield return new WaitForSeconds (interval);
			count -= 1;
		}
	}
}
