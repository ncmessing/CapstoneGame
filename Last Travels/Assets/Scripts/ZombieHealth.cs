using UnityEngine;
using System.Collections;

public class ZombieHealth : MonoBehaviour {

	public int HP;

	public void Damage(int damageCount)
	{
		HP -= damageCount;
		if (HP <= 0) 
			Destroy (gameObject);
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Damager")
			Damage (other.gameObject.GetComponent<PlayerProjectile>().damage);
	}
}