using UnityEngine;
using System.Collections;

public class PickupWeapon : MonoBehaviour {

	public Sprite gun;
	public string wepName;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponentInParent<PlayerMovement>().SetWeapon(this.gun, this.wepName);
			Destroy(gameObject);
		}
	}
}
