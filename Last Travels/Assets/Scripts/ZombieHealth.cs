using UnityEngine;
using System.Collections;

public class ZombieHealth : MonoBehaviour {

	public double HP;

	public void Damage(double damage)
	{
		Debug.Log ("Zombie took damage");
		HP -= damage;
		if (HP <= 0)
		{
			Debug.Log("Zombie Die");
			Destroy (gameObject);
		}
	}
}