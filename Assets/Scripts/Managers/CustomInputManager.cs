using UnityEngine;

public class CustomInputManager : MonoBehaviour
{
    public GameObject Player;
    private static IPlayerMovement _movementComponent;

    private void Awake()
    {
        _movementComponent = Player.GetComponent<IPlayerMovement>();

        if (_movementComponent == null)
        {
            Debug.LogError("No IPlayerMovement interface set");
            return;
        }
    }

    void Update()
    {
        //horizontal movement
        HorizontalMovement(Input.GetAxisRaw("Horizontal"));

        //jump
        if (Input.GetKeyDown(KeyCode.Space))
            Jump_performed();
    }

    private static void HorizontalMovement(float value)
    {
        _movementComponent.HorizontalMovement(value);
    }

    private static void Jump_performed()
    {
        _movementComponent.Jump();
    }
}
