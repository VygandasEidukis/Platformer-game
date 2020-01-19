using UnityEngine;
using UnityEngine.Experimental.Input;

public class InputManager : MonoBehaviour
{
	public MainInputActions inputActions;
	public GameObject Player;

	private static MainInputActions _inputActions;
	private static IPlayerMovement _movementComponent;

	private void Awake()
	{
		_inputActions = inputActions;
		_movementComponent = Player.GetComponent<IPlayerMovement>();

		if (_movementComponent == null)
		{
			Debug.LogError("No IPlayerMovement interface set");
			return;
		}

		SetUpInputEvents();
	}
	private void OnDisable()
	{
		ResetInputEvents();
	}
	private static void SetUpInputEvents()
	{
		_inputActions.MovementBase.HorizontalMovement.started += HorizontalMovement;
		_inputActions.MovementBase.HorizontalMovement.performed += HorizontalMovement;
		_inputActions.MovementBase.HorizontalMovement.cancelled += HorizontalMovement;
		_inputActions.MovementBase.HorizontalMovement.Enable();

		_inputActions.MovementBase.Jump.performed += Jump_performed;
		_inputActions.MovementBase.Jump.Enable();
	}

	private static void ResetInputEvents()
	{
		_inputActions.MovementBase.HorizontalMovement.started -= HorizontalMovement;
		_inputActions.MovementBase.HorizontalMovement.performed -= HorizontalMovement;
		_inputActions.MovementBase.HorizontalMovement.cancelled -= HorizontalMovement;

		_inputActions.MovementBase.Jump.performed -= Jump_performed;
	}

	private static void HorizontalMovement(InputAction.CallbackContext context)
	{
		_movementComponent.HorizontalMovement(context.ReadValue<float>());
	}

	private static void Jump_performed(InputAction.CallbackContext context)
	{
		_movementComponent.Jump();
	}
}
