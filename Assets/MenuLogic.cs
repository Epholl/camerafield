using UnityEngine;
using System.Collections;

public class MenuLogic : MonoBehaviour {

	public Camera mainCamera;

	public void RoundCameraValues() {

		float x = mainCamera.transform.position.x;
		float y = mainCamera.transform.position.y;
		float z = mainCamera.transform.position.z;

		x = Mathf.Round (x*2) /2;
		y = Mathf.Round (y*2) /2;
		z = Mathf.Round (z*2) /2;

		float rotX = mainCamera.transform.eulerAngles.x;
		float rotY = mainCamera.transform.eulerAngles.y;
		float rotZ = mainCamera.transform.eulerAngles.z;

		rotX = Mathf.Round (rotX);
		rotY = Mathf.Round (rotY);
		rotZ = Mathf.Round (rotZ);

		mainCamera.transform.position = new Vector3 (x, y, z);
		mainCamera.transform.eulerAngles = new Vector3 (rotX, rotY, rotZ);
	}
}
