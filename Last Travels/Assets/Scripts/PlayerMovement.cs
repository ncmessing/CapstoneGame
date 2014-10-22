using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;

	private Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);

		bool moving = false;
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.right * speed);
			moving = true;
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate(-Vector2.right * speed);
			moving = true;
		}
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(Vector2.up * speed);
			moving = true;
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(-Vector2.up * speed);
			moving = true;
		}
		if (moving == false)
						anim.Play ("Player Idle");
				else
						anim.Play ("Player Moving");


	}
}
