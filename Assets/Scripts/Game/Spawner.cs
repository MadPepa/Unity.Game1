using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;
    [SerializeField] private GameObject _coin;
    [SerializeField] private float _obstacleCooldown;

    private float _spawnDistance = 1;
    private float _timer;
    private int _coinCount;

    private void Start()
    {
        _timer = _obstacleCooldown * Random.value;
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _obstacleCooldown + Random.value)
        {
            _timer = 0;
            
            if (Random.Range(0,3) < 2)
            {
                Instantiate(_obstacle, transform.position, new Quaternion());
            }
            else
            {
                _coinCount = Random.Range(3, 6);

                for (int i = 0; i < _coinCount; i++)
                    Instantiate(_coin, new Vector3(transform.position.x + _spawnDistance * i, transform.position.y), new Quaternion());
            }
        }
    }
}
