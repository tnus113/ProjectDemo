using UnityEngine;

public class RotateSpeedWithTime : MonoBehaviour
{
	public GameObject cube1;
	public GameObject cube2;
	public float rotationSpeed = 5.0f;
	// Update is called once per frame
	void Update()
	{
		cube1.transform.Rotate(Vector3.up * rotationSpeed);
		cube2.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
	}
}
