using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        GameManager.Instance.AddScore(scoreValue);
        GameManager.Instance.CoinCollected();
        Destroy(gameObject);
    
    }
}
