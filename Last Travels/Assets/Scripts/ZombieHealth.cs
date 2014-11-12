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
		Debug.Log (other.gameObject.name);
		if (other.gameObject.name == "PlayerProjectile")
		{
			PlayerProjectile pp = other.gameObject.GetComponent<PlayerProjectile> ();
			Debug.Log(pp);
			if (other.gameObject.tag == "Damager")
						Damage (pp.damage);
			Destroy(other);
		}
		else if (other.gameObject.name == "Player Right Arm" || other.gameObject.name == "Player Left Arm")
		{
			PlayerAttack pa = other.gameObject.GetComponent<PlayerAttack> ();
			Debug.Log(pa);
			if (other.gameObject.tag == "Damager")
				Damage (pa.damage);
		}
	}
}