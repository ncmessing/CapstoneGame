using UnityEngine;
using System.Collections;

public class PunchCollide : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
			Destroy (other.collider2D.transform.parent.gameObject);
	}
}