using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform player;
	public Camera camera;

	void FixedUpdate () {
		if (player != null)
		{
			transform.position = player.position + new Vector3 (player.eulerAngles.x, player.eulerAngles.y, -10);

			if (Input.GetKey(KeyCode.KeypadPlus))
			{
				camera.orthographicSize++;
				buttonPress(KeyCode.KeypadPlus);
			}
			else if (Input.GetKey(KeyCode.KeypadMinus))
			{
				if (camera.orthographicSize > 1)
					camera.orthographicSize--;
				buttonPress(KeyCode.KeypadMinus);
			}
		}
	}

	IEnumerator buttonPress(KeyCode key)
	{
		if (key == KeyCode.KeypadPlus)
		{
			camera.orthographicSize++;
			yield return new WaitForSeconds(0.5f);
				}
		else if (key == KeyCode.KeypadPlus)
		{
			camera.orthographicSize--;
			yield return new WaitForSeconds(0.5f);
		}
	}
}