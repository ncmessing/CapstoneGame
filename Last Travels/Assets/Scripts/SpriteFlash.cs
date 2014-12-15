using UnityEngine;
using System.Collections;

public class SpriteFlash : MonoBehaviour {

	private SpriteRenderer sprite_render;
	private bool damaged = false;
	private double playerHP;

	void Start() {
		sprite_render = GetComponent<SpriteRenderer> ();
		sprite_render.enabled = false;
	}

	void FixedUpdate ()
	{
		if (PlayerMovement.tookDamage == true)
		{
			damaged = true;
		}
		if (damaged == true)
		{
			sprite_render.enabled = true;
		}
		else if (damaged == false)
		{
			sprite_render.enabled = false;
		}
		damaged = false;
	}
}
