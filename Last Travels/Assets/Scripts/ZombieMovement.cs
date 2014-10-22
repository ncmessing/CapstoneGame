using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
	public float speed;
	public Transform player;

	private Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y),
		                       (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;

		transform.eulerAngles = new Vector3 (0, 0, z);

		transform.Translate(Vector2.up * speed);
		anim.Play ("Zombie Moving");
	}
}
