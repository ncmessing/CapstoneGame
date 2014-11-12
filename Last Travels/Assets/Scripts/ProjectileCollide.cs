using UnityEngine;
using System.Collections;

public class ProjectileCollide : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		//if (other.gameObject.tag == "Enemy")
		//	other.gameObject.GetComponent<ZombieHealth>().Damage(1);
		Destroy (this);
	}
}