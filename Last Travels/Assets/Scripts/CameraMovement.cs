using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Transform target;
	void Start () {
		target = GameObject.Find("Player").transform;
	}

	void FixedUpdate () {
		transform.position = target.position + new Vector3 (target.eulerAngles.x, target.eulerAngles.y, -10);
	}
}
