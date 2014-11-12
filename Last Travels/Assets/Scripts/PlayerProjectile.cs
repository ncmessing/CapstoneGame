using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

	public Rigidbody projectile;
	float attackSpeed = 0.5f;
	float coolDown;
	

	// Update is called once per frame
	void Update () 
	{

		if (Time.time >= coolDown) 
		{
			if (Input.GetKey (KeyCode.Space)) 
			{
				Fire ();
			}
		}
	
	}

	void Fire()
	{
		Rigidbody proj = Instantiate (projectile, transform.position, Quaternion.identity) as Rigidbody;
		proj.rigidbody.AddForce (transform.up * 500);
		coolDown = Time.time + attackSpeed;
}
}
