using UnityEngine;
using System.Collections;

public class ProjectileCollide : MonoBehaviour {

	public float travelTimer = 50;
	public float travelDuration = 5f;
	
	private float coolDown;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag != "Player" && other.gameObject.tag != "Damager")
		{
			if (other.gameObject.tag == "Enemy")
			{
				ZombieHealth zh = other.GetComponentInParent<ZombieHealth>();
				zh.Damage(PlayerProjectile.projDamage);
			}
			if (other.gameObject.tag != "Weapon" && other.gameObject.tag != "BG")
				Destroy (gameObject);
		}
	}

	void FixedUpdate()
	{
		if (travelTimer != 0)
			travelTimer -= 0.5f;
		if (travelTimer <= 0) 
			Destroy (gameObject);
	}


}