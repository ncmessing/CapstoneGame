using UnityEngine;
using System.Collections;

public class PunchCollide : MonoBehaviour {
	/*static public bool isPunching;

	void Start()
	{
		isPunching = false;
	}*/

	void OnTriggerEnter2D(Collider2D other)
	{
		//if (isPunching)
		//{
			if (other.tag == "Enemy")
				Destroy (other.collider2D.transform.parent.gameObject);
		//}
	}
}