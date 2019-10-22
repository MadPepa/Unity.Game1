using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private GameObject _jumpPoint;
    [SerializeField] private LayerMask _jumpLayer;

    internal bool CanJump()
    {
        return Physics2D.OverlapCircle(_jumpPoint.transform.position, _radius, _jumpLayer);
    }
}
