using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public Camera mainCamera;

	void FixedUpdate () {

		float x = mainCamera.transform.position.x;
		float y = mainCamera.transform.position.y;
		float z = mainCamera.transform.position.z;
	
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

		mainCamera.transform.position = new Vector3(x, y, z);
	}
}
