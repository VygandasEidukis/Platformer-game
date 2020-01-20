using UnityEngine;

public abstract class PhysicsObject : MonoBehaviour
{
    public bool isGrounded => IsColliding(_collisionLayer, _groundChecker, _groundCheckRadius);

    [Header("Ground collision")]
    [SerializeField] private float _groundCheckRadius;
    [SerializeField] private LayerMask _collisionLayer;
    [SerializeField] private Transform _groundChecker;

    private bool IsColliding(LayerMask layerMask, Transform checker, float radius)
    {
        if (checker == null)
            return false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(checker.position, radius, layerMask); 
        return colliders.Length > 0;
    }
}
