using UnityEngine;

[RequireComponent(typeof(GroundChecker))]
public class Jump : MonoBehaviour
{
    private GroundChecker _jumpChecker;
    private Rigidbody2D _ball;
    private float _jumpForce = 8;

    private void Start()
    {
        _ball = GetComponent<Rigidbody2D>();
        _jumpChecker = GetComponent<GroundChecker>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            if (_jumpChecker.CanJump())
                _ball.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
