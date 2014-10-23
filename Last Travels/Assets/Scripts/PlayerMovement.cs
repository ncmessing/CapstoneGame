using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	public float sprintSpeed;
	public float sneakSpeed;

	private Animator anim;
	private bool moving;
	private bool sneaking;
	private bool sprinting;

	void Start() {
		anim = GetComponent<Animator> ();
		moving = false;
		sneaking = false;
		sprinting = false;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);

		float movingSpeed = speed;
		if (sneaking == true)
			movingSpeed = sneakSpeed;

		if (Input.GetKey(KeyCode.LeftShift))
		{
			sprinting = true;
			sneaking = false;
			movingSpeed = sprintSpeed;
		}
		if (Input.GetKey(KeyCode.C))
		{
			if (sneaking == false)
			{
				sneaking = true;
				movingSpeed = sneakSpeed;
			}
			else
			{
				sneaking = false;
				movingSpeed = speed;
			}
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.right * movingSpeed);
			moving = true;
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate(-Vector2.right * movingSpeed);
			moving = true;
		}
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(Vector2.up * movingSpeed);
			moving = true;
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(-Vector2.up * movingSpeed);
			moving = true;
		}
		if (moving == false)
			anim.Play ("Player Idle");
		else // player is moving
			anim.Play ("Player Moving");


	}
}
