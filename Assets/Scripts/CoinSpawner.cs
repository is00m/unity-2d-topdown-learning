using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private int coinCount = 10;

    [Header("Spawn Area")]
    [SerializeField] private Vector2 minXY = new Vector2(-8, -3);
    [SerializeField] private Vector2 maxXY = new Vector2(8, 3);

    private void Start()
    {
        for (int i = 0; i < coinCount; i++)
        {
            SpawnOne();
        }
    }

    private void SpawnOne()
    {
        float x = Random.Range(minXY.x, maxXY.x);
        float y = Random.Range(minXY.y, maxXY.y);

        Instantiate(coinPrefab, new Vector3(x, y, 0f), Quaternion.identity);
    }
}
