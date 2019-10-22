using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private Text _coinCounter;
<<<<<<< Updated upstream

    [SerializeField] private int _coinCount = 0;
=======
    [SerializeField] private int _coinCount = 0;
    const int _coinLayer = 11;
>>>>>>> Stashed changes

    private void Start()
    {
        _coinCounter.text = _coinCount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< Updated upstream
        if (collision.gameObject.layer == 11)
=======
        if (collision.gameObject.layer == _coinLayer)
>>>>>>> Stashed changes
        {
            _coinCount++;
            _coinCounter.text = _coinCount.ToString();
            Destroy(collision.gameObject);
        }
    }
}
