using UnityEngine;

public class Movement : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == _end)
            Destroy(collision.gameObject);
    }
}
