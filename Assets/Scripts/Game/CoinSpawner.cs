using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnedObject;
    [SerializeField] private float _spawnTime;

    private System.Random _random = new System.Random();
    private float _timer = 0;
    private float _spawnDistance = 1;

    private void Start()
    {
        _timer = _spawnTime * (float)_random.NextDouble();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnTime + _random.NextDouble())
        {
            _timer = 0;

            int count = _random.Next(1, 6);
            for (int i = 0; i < count; i++)
                Instantiate(_spawnedObject, new Vector3(transform.position.x + _spawnDistance * i, transform.position.y + i * 0.4f), new Quaternion());
        }
    }
}
