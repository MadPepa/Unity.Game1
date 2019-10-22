using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;
    [SerializeField] private GameObject _coin;
    [SerializeField] private float _coinSpawnTime;
    [SerializeField] private float _obstacleSpawnTime;

    private System.Random _random = new System.Random();
    private float _spawnDistance = 1;
    private float _coinTimer;
    private float _obstacleTimer;

    private void Start()
    {
        _coinTimer = _coinSpawnTime * (float)_random.NextDouble();
        _obstacleTimer = _obstacleSpawnTime * (float)_random.NextDouble();
    }

    private void Update()
    {
        _coinTimer += Time.deltaTime;
        _obstacleTimer += Time.deltaTime;

        if (_obstacleTimer >= _obstacleSpawnTime + _random.NextDouble())
        {
            _obstacleTimer = 0;

            Instantiate(_obstacle, transform.position, new Quaternion());
        }

        if (_coinTimer >= _coinSpawnTime + _random.NextDouble())
        {
            _coinTimer = 0;

            int count = _random.Next(1, 6);
            for (int i = 0; i < count; i++)
                Instantiate(_coin, new Vector3(transform.position.x + _spawnDistance * i, transform.position.y + 2 + i * 0.4f), new Quaternion());
        }
    }
}
