using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private Transform _point;
    [SerializeField] private LayerMask _layer;

    public bool CanJump()
    {
        return Physics2D.OverlapCircle(_point.position, _radius, _layer);
    }
}
