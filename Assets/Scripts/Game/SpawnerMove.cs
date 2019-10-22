using UnityEngine;

public class SpawnerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
<<<<<<< Updated upstream
    public int Direction { get; private set; } = 1;

    private Rigidbody2D _spawner;

    private void Start()
    {
        _spawner = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _spawner.velocity = new Vector2(0, Direction) * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Direction = -Direction;
=======
    [SerializeField] private float _topBorder;
    [SerializeField] private float _bottomBorder;

    public enum Direction {Up = 1, Down = -1};
    private Direction _direction = Direction.Up; 

    private void Update()
    {
        transform.Translate(new Vector3(0, (float)_direction) * _speed * Time.deltaTime, 0);

        if (transform.position.y > _topBorder)
            _direction = Direction.Down;

        if (transform.position.y < _bottomBorder)
            _direction = Direction.Up;
>>>>>>> Stashed changes
    }
}
