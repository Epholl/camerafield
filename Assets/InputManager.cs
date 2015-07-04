using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public static float ROTATION_SPEED = 120f;
	public static float MOVEMENT_SPEED = 0.5f;

	private float multiplier = 1f;

	public Camera mainCamera;

	void FixedUpdate () {

		float x = 0f;
		float y = 0f;
		float z = 0f;
	
		if (Input.GetKey ("up") || Input.GetKey("w")) {
			z++;
		}
		if (Input.GetKey ("down") || Input.GetKey("s")) {
			z--;
		}
		if (Input.GetKey ("left") || Input.GetKey("a")) {
			x--;
		}
		if (Input.GetKey ("right") || Input.GetKey("d")) {
			x++;
		}
		if (Input.GetKey ("left shift")) {
			multiplier = 0.2f;
		} else {
			multiplier = 1f;
		}

		float hdg = 0f;
		if (Input.GetKey ("q")) {
			hdg = -ROTATION_SPEED;
		}
		if (Input.GetKey ("e")) {
			hdg = ROTATION_SPEED;
		}

		mainCamera.transform.Translate(new Vector3 (x, y, z) * MOVEMENT_SPEED * multiplier);
		mainCamera.transform.Rotate(new Vector3(0f, hdg, 0f) * Time.fixedDeltaTime * multiplier);
	}
}
