using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenDataActualizer : MonoBehaviour {

	public Camera mainCamera;

	public Text textX;
	public Text textZ;
	public Text textY;
	public Text textFOV;

	// Update is called once per frame
	void Update () {

		textX.text = "Offset X: " + mainCamera.transform.position.x;
		textZ.text = "Offset Z: " + mainCamera.transform.position.z;
		textY.text = "Altitude: " + mainCamera.transform.position.y;
		textFOV.text = "FOV: " + mainCamera.fieldOfView;
	}
}
