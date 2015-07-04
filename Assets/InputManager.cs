using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public static float ROTATION_SPEED = 1f;
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
		if (Input.GetKey ("space")) { 
			y++;
		}
		if (Input.GetKey ("left ctrl")) { 
			y--;
		}

		if (Input.GetKey ("left shift")) {
			multiplier = 0.2f;
		} else {
			multiplier = 1f;
		}

		float hdg = 0f;
		float pitch = 0f;
		if (Input.GetKey ("q")) {
			hdg--;
		}
		if (Input.GetKey ("e")) {
			hdg++;
		}
		if (Input.GetKey ("f")) {
			pitch++;
		}
		if (Input.GetKey ("r")) {
			pitch--;
		}

		float cameraY = mainCamera.transform.position.y;
		mainCamera.transform.Translate(new Vector3 (x, 0f, z) * MOVEMENT_SPEED * multiplier);

		Vector3 newPosition = mainCamera.transform.position;
		newPosition.y = cameraY + y * MOVEMENT_SPEED * multiplier;
		mainCamera.transform.position = newPosition;
		mainCamera.transform.Rotate(new Vector3(0f, hdg, 0f) * ROTATION_SPEED * multiplier, Space.World);
		mainCamera.transform.Rotate(new Vector3(pitch, 0f, 0f) * ROTATION_SPEED * multiplier, Space.Self);
	}
}
