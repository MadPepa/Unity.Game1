using UnityEngine;

public class SpawnerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
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
    }
}
