﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	public float sprintSpeed;
	public float sneakSpeed;
	public double health;
	public Sprite weapon;
	public string wepName;

	private Animator anim;
	private SpriteRenderer sr;
	private PlayerProjectile pp;

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

	//poison
	public float poisonTimer = 0;
	public float poisonCoolDown = 3f;
	private float coolDown;
	public float poisonDuration;
	public bool poisonedBool = false;

	//gun values
	static public bool gunEquipped = true;

	void Start() {
		anim = GetComponent<Animator> ();
		moving = false;
		sneaking = false;
		sprinting = false;
		gunEquipped = true;
		sr = GetComponent<SpriteRenderer> ();
		pp = GetComponent<PlayerProjectile> ();
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

		//poison check

		if (Time.time >= coolDown)
			if (poisonedBool==true)
						PoisonCheck();

		if (poisonTimer != 0)
		{
			this.health -= 0.01f;
			tookDamage = !tookDamage;
			poisonTimer -= 0.25f;
			startingHealth = this.health;
			if (this.health <= 0)
			{
				Destroy (gameObject);
				Application.LoadLevel("DeadLevel");
			}
		}

		if (gunEquipped)
			sr.enabled = true;
		else
			sr.enabled = false;
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

	public void SetWeapon(Sprite newWeapon, string newWepName)
	{
		this.weapon = newWeapon;
		this.wepName = newWepName;
		sr.sprite = (Sprite) newWeapon;
		if (this.wepName == "Magnum")
			pp.SetStats (0.5F, 1);
		else if (this.wepName == "AK47")
			pp.SetStats (0.2F, .5F);
		else if (this.wepName == "M4A1")
			pp.SetStats (0.1F, .35F);
	}

	public void PoisonCheck()
	{
		if (poisonTimer==0)
		{
			poisonTimer = poisonCoolDown;
			poisonedBool = false;
		}
		coolDown = Time.time + poisonDuration;
	}
}
