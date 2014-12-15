using UnityEngine;
using System.Collections;

public class ZombieHealth : MonoBehaviour {

	public double HP;

	public void Damage(double damage)
	{
		HP -= damage;
		if (HP <= 0)
		{
			Destroy (gameObject);
		}
	}
}