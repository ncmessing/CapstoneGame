using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

	public Rigidbody2D projectile;
	public float attackSpeed;
	public int projSpeed;
	public static float projDamage = 1;
	public float soundTimer = 0;
	public float soundCoolDown = 5f;

	public AudioClip shotSound;

	private float coolDown;
	

	// Update called once per frame
	void FixedUpdate () 
	{
		if (Time.time >= coolDown) 
			if (Input.GetKey (KeyCode.Space)) 
				Fire ();
		
		if (soundTimer != 0)
			soundTimer -= 0.5f;
	}

	void Fire()
	{

		if (soundTimer == 0) 
		{
			audio.PlayOneShot (shotSound);
			soundTimer = soundCoolDown;
		}

		Rigidbody2D proj = Instantiate (projectile, transform.position, Quaternion.identity) as Rigidbody2D;
		proj.rigidbody2D.AddForce (transform.up * projSpeed);
		coolDown = Time.time + attackSpeed;
	}

	public void SetStats(float atts, float dam)
	{
		this.attackSpeed = atts;
		projDamage = dam;
	}
}
