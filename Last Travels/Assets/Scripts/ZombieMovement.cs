using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
	public float speed;
	public Transform player;

	private bool agro;
	private Animator anim;
	private bool hittingPlayer;

	void Start()
	{
		agro = false;
		anim = GetComponent<Animator> ();
		hittingPlayer = false;
	}

	void FixedUpdate ()
	{
		float dist = Vector3.Distance (transform.position, player.position);
		if (dist <= 4.0)
			agro = true;
		else
			agro = false;

		if (agro == true)
		{
			float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y),
		              (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;

			transform.eulerAngles = new Vector3 (0, 0, z);

			if (hittingPlayer == false)
			{
				transform.Translate (Vector2.up * speed);
				anim.Play ("Zombie Moving");
			}
			else
				anim.Play ("Zombie Idle");
		}
		else
			anim.Play ("Zombie Idle");
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
			hittingPlayer = true;
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
			hittingPlayer = false;
	}
}
