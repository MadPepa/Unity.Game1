using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private Text _coinCounter;

    [SerializeField] private int _coinCount = 0;

    private void Start()
    {
        _coinCounter.text = _coinCount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            _coinCount++;
            _coinCounter.text = _coinCount.ToString();
            Destroy(collision.gameObject);
        }
    }
}
