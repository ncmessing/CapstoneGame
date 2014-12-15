using UnityEngine;
using System.Collections;

public class PunchCollide : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
			other.GetComponentInParent<ZombieHealth> ().Damage (.5);
	}
}