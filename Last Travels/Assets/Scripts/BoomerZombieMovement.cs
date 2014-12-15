
using UnityEngine;
using System.Collections;

public class BoomerZombieMovement : MonoBehaviour {
	public float speed;
	public float agroRange;
	public Transform player;
	public bool dead;
	
	private bool agro;
	private Animator anim;
	private float modAgroRange;
	private bool booming;
	public AudioClip aggroSound;
	public AudioClip explosionSound;
	public bool soundPlayed = false;
	
	void Start()
	{
		agro = false;
		anim = GetComponent<Animator> ();
		modAgroRange = agroRange;
	}
	
	void FixedUpdate ()
	{
		if (dead == true)
			Destroy(gameObject);
		if (player != null)
		{
			// Calculates distance from player
			float dist = Vector3.Distance (transform.position, player.position);
			// Modifies agro range depending on player movement type
			if (PlayerMovement.moving == true)
			{
				if (PlayerMovement.sprinting == true)
					modAgroRange = agroRange * 2;
				else if (PlayerMovement.sneaking == true && agro == false)
					modAgroRange = agroRange / 2;
				else
					modAgroRange = agroRange;
			}
			// Checks agro range compared to distance
			if (dist <= modAgroRange)
				agro = true;
			else
				agro = false;
			
			if (agro == true)
			{
				// calulates which direction to look at (towards player)
				float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y),
				                       (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
				
				transform.eulerAngles = new Vector3 (0, 0, z);
				
				if (dist >= .7)
				{
					transform.Translate (Vector2.up * speed);
					anim.Play ("Zombie Moving");
					if (soundPlayed == false)
					{
						audio.PlayOneShot(aggroSound);
						soundPlayed = true;
					}
				}
				else
				{
					audio.PlayOneShot(explosionSound);
					anim.Play ("Boomer Explode");
					booming = true;
					player = null;
					
				}
			}
			else
				anim.Play ("Zombie Idle");
		}
		else if (booming == false)
			anim.Play("Zombie Idle");
	}
}

