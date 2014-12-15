﻿using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour {
	public string nextLevel;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			Application.LoadLevel(nextLevel);
	}
}
