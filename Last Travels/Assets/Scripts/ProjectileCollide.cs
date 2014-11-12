using UnityEngine;
using System.Collections;

public class ProjectileCollide : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag != "Player" && other.gameObject.tag != "Damager")
			Destroy (this.gameObject);
	}
}