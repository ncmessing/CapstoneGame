using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

	public Rigidbody projectile;
	public float attackSpeed;
	public int projSpeed;
	public int damage = 1;

	private float coolDown;
	

	// Update called once per frame
	void FixedUpdate () 
	{
		if (Time.time >= coolDown) 
			if (Input.GetKey (KeyCode.Space)) 
				Fire ();
	}

	void Fire()
	{
		Rigidbody proj = Instantiate (projectile, transform.position, Quaternion.identity) as Rigidbody;
		proj.rigidbody.AddForce (transform.up * projSpeed);
		coolDown = Time.time + attackSpeed;
	}
}
