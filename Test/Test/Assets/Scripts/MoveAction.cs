using UnityEngine;
using UnityEngine;
using UnityEngine.InputSystem;

public class MobileMoveReader : MonoBehaviour
{
	[SerializeField] InputActionReference moveAction;

	void OnEnable() => moveAction.action.Enable();
	void OnDisable() => moveAction.action.Disable();

	void Update()
	{
		Vector2 move = moveAction.action.ReadValue<Vector2>();
		// Pass to movement code, in lesson, I cannot find it rn :I Thanks visual Studio!!!
	}
}
