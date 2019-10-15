using UnityEngine;

public class SpawnerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
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
    }
}
