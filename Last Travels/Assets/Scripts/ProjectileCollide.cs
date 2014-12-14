using UnityEngine;
using System.Collections;

public class ProjectileCollide : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag != "Player" && other.gameObject.tag != "Damager")
		{
			if (other.gameObject.tag == "Enemy")
			{
				ZombieHealth zh = other.GetComponent<ZombieHealth>();
				zh.Damage(1);
			}
			Destroy (gameObject);
		}
	}
}