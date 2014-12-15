using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	public float sprintSpeed;
	public float sneakSpeed;
	public double health;

	private Animator anim;

	static public bool moving;
	static public bool sneaking;
	static public bool sprinting;
	static public bool tookDamage;

	public double originalHealth;
	static public double startingHealth = 5;
	static public bool Sprite2 = false;
	static public bool Sprite3 = false;
	static public bool Sprite4 = false;
	static public bool Sprite5 = false;


	void Start() {
		anim = GetComponent<Animator> ();
		moving = false;
		sneaking = false;
		sprinting = false;
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		moving = false;
		tookDamage = false;
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);

		float movingSpeed = speed;

		if (Input.GetKey(KeyCode.LeftShift))
		{
			sprinting = true;
			sneaking = false;
			movingSpeed = sprintSpeed;
		}
		else if (Input.GetKey(KeyCode.LeftControl))
		{
			sneaking = true;
			sprinting = false;
			movingSpeed = sneakSpeed;
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

	public void Damage(double damage)
	{
		tookDamage = true;
		this.health -= damage;
		if (this.health <= 0)
		{
			Destroy (gameObject);
			Application.LoadLevel("DeadLevel");
		}

		startingHealth = this.health;

		if (originalHealth / 5 >= this.health) 
		{
			Sprite5 = true;
		} 
		else if (originalHealth / 4 >= this.health) 
		{
			Sprite4 = true;
		} 
		else if (originalHealth / 3 >= this.health) 
		{
			Sprite3 = true;
		} 
		else if (originalHealth / 2 >= this.health) 
		{
			Sprite2 = true;
		}


	}


}
