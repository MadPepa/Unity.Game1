using UnityEngine;

<<<<<<< Updated upstream
[RequireComponent(typeof(JumpChecker))]
=======
[RequireComponent(typeof(GroundChecker))]
>>>>>>> Stashed changes
public class Jump : MonoBehaviour
{
    private Rigidbody2D _ball;
    private float _jumpForce = 8;

<<<<<<< Updated upstream
    private JumpChecker _jumpChecker;
    private void Start()
    {
        _ball = GetComponent<Rigidbody2D>();
        _jumpChecker = GetComponent<JumpChecker>();
=======
    private GroundChecker _jumpChecker;
    private void Start()
    {
        _ball = GetComponent<Rigidbody2D>();
        _jumpChecker = GetComponent<GroundChecker>();
>>>>>>> Stashed changes
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
<<<<<<< Updated upstream
            if (_jumpChecker.JumpCheck())
=======
            if (_jumpChecker.CanJump())
>>>>>>> Stashed changes
                _ball.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
