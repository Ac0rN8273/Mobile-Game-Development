using UnityEngine;
using UnityEngine.InputSystem;

public class TiltSample : MonoBehaviour
{
	[SerializeField] float deadZone = 0.05f;
	[SerializeField] float sensitivity = 2f;
	Vector3 neutral;

	void OnEnable()
	{
		if (Accelerometer.current != null)
			InputSystem.EnableDevice(Accelerometer.current);
	}

	public void Calibrate()
	{
		if (Accelerometer.current != null)
			neutral = Accelerometer.current.acceleration.ReadValue();
	}

	public float ReadTilt()
	{
		if (Accelerometer.current == null) return 0f;
		float x = Accelerometer.current.acceleration.ReadValue().x - neutral.x;
		if (Mathf.Abs(x) < deadZone) x = 0f;
		return Mathf.Clamp(x * sensitivity, -1f, 1f);
	}
}