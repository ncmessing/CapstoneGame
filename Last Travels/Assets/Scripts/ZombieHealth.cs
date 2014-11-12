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
		PlayerProjectile pp = other.gameObject.GetComponent<PlayerProjectile> ();
		Debug.Log(pp);
		if (pp != null)
		{
			Damage (pp.damage);
			Destroy (other);
		}

		PlayerAttack pa = other.gameObject.GetComponent<PlayerAttack> ();
		Debug.Log(pa);
		if (pa != null)
			Damage (pa.damage);
	}
}