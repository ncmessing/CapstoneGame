using UnityEngine;
using System.Collections;

public class GunSprite : MonoBehaviour {
	
	private SpriteRenderer sprite_render;
	private bool equipped = false;
	
	void Start() {
		sprite_render = GetComponent<SpriteRenderer> ();
		sprite_render.enabled = false;
	}
	
	void FixedUpdate ()
	{
		if (PlayerMovement.ak47_equipped== true)
		{
			equipped = true;
		}
		if (equipped == true)
		{
			sprite_render.enabled = true;
		}
		else if (equipped == false)
		{
			sprite_render.enabled = false;
		}
	}
}
