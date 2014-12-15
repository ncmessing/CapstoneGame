using UnityEngine;
using System.Collections;

public class BoomerZombieHit : MonoBehaviour {
	private PlayerMovement player;
	
	public AudioClip damageSound;
	public bool soundPlayed = false;
	public float soundTimer = 0;
	public float soundCoolDown = 2f;
	private float coolDown;
	public float replaySpeed;
	
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
		player.Damage (.2);
		if (Time.time >= coolDown) 
		{
			if (soundTimer != 0)
				soundTimer -= 0.5f;
			else
			{
				audio.PlayOneShot(damageSound);
				soundTimer = soundCoolDown;
				coolDown = Time.time + replaySpeed;
			}
			
			
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			CancelInvoke();
	}
}
