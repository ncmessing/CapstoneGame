using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	private Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		if (Input.GetMouseButton (0))
			anim.Play ("Player Punch");
	}
}
