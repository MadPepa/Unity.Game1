using UnityEngine;

public class JumpChecker : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private GameObject _jumpPoint;
    [SerializeField] private LayerMask _jumpLayer;

    internal bool JumpCheck()
    {
        return Physics2D.OverlapCircle(_jumpPoint.transform.position, _radius, _jumpLayer);
    }
}
