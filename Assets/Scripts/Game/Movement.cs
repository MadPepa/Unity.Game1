using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _speed = 2.5f;

    private void Start()
    {
        Destroy(gameObject, 12);
    }

    private void Update()
    {
        transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 12)
            Destroy(collision.gameObject);
    }
}
