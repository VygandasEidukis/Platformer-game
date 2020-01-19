using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class InputManager : MonoBehaviour
{
	public MainInputActions inputActions;
	public GameObject Player;

	private static MainInputActions _inputActions;
	private static ICanMove _movementComponent;

	private void Awake()
	{
		_inputActions = inputActions;
		_movementComponent = Player.GetComponent<ICanMove>();

		if (_movementComponent == null)
		{
			Debug.LogError("No ICanMove interface set");
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
		_inputActions.MovementBase.HorizontalMovement.performed += HorizontalMovement_performed;
		_inputActions.MovementBase.HorizontalMovement.Enable();

		_inputActions.MovementBase.Jump.performed += Jump_performed;
		_inputActions.MovementBase.Jump.Enable();
	}

	private static void ResetInputEvents()
	{
		_inputActions.MovementBase.HorizontalMovement.performed -= HorizontalMovement_performed;
		_inputActions.MovementBase.Jump.performed -= Jump_performed;
	}

	private static void Jump_performed(InputAction.CallbackContext obj)
	{
		_movementComponent.Jump();
	}

	private static void HorizontalMovement_performed(InputAction.CallbackContext obj)
	{
		_movementComponent.HorizontalMovement(obj.ReadValue<float>());
	}
}
