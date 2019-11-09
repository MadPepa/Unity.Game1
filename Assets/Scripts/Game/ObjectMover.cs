using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private int _end;

    private float _speed = 2.5f;

    private void Start()
    {
        Destroy(gameObject, 12);
    }

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
