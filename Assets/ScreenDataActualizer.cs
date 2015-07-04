using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenDataActualizer : MonoBehaviour {

	public Camera mainCamera;

	public Text textX;
	public Text textZ;
	public Text textY;
	public Text textHeading;
	public Text textPitch;
	public Text textFOV;

	// Update is called once per frame
	void Update () {

		textX.text = "Offset X: " + mainCamera.transform.position.x;
		textZ.text = "Offset Z: " + mainCamera.transform.position.z;
		textY.text = "Altitude: " + mainCamera.transform.position.y;
		textHeading.text = "Hdg: " + mainCamera.transform.rotation.eulerAngles.y;
		textPitch.text = "Pitch: " + mainCamera.transform.eulerAngles.x;
		textFOV.text = "FOV: " + mainCamera.fieldOfView + " (V), " + Round(GetHorizontalCameraFOV(), 1) + " (H).";
	}

	private float GetHorizontalCameraFOV() {
		float verticalFOV = (mainCamera.fieldOfView / 180) * Mathf.PI;
		float aspect = GetAspectRatio();

		float radianFOV = 2 * Mathf.Atan(Mathf.Tan(verticalFOV / 2) * aspect);
		return radianFOV * 180 / Mathf.PI;
	}

	private float GetAspectRatio() {
		return mainCamera.pixelWidth / mainCamera.pixelHeight;
	}

	private float Round(float rounded, int decimalPlaces) {
		int multiplier = (int) Mathf.Pow (10, decimalPlaces);

		return Mathf.Round (rounded * multiplier) / multiplier;
	}
}
