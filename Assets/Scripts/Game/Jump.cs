using UnityEngine;

[RequireComponent(typeof(JumpChecker))]
public class Jump : MonoBehaviour
{
    private Rigidbody2D _ball;
    private float _jumpForce = 8;

    private JumpChecker _jumpChecker;
    private void Start()
    {
        _ball = GetComponent<Rigidbody2D>();
        _jumpChecker = GetComponent<JumpChecker>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            if (_jumpChecker.JumpCheck())
                _ball.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
