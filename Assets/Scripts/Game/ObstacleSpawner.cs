using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _spawnedObject;
    [SerializeField] private float _spawnTime;

    private System.Random _random = new System.Random();
    private float _timer;

    private void Start()
    {
        _timer = _spawnTime * (float)_random.NextDouble();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if(_timer >= _spawnTime + _random.NextDouble())
        {
            _timer = 0;

            Instantiate(_spawnedObject, transform.position, new Quaternion());
        }
    }
}
