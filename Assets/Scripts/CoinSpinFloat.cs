using UnityEngine;

public class CoinSpinFloat : MonoBehaviour
{
    [Header("Spin")]
    [SerializeField] private float rotateSpeed = 180f;

    [Header("Float")]
    [SerializeField] private float floatAmplitude = 0.15f;
    [SerializeField] private float floatFrequency = 2f;

    [Header("Pulse")]
    [SerializeField] private float pulseAmplitude = 0.06f;
    [SerializeField] private float pulseFrequency = 3f;

    private Vector3 startPos;
    private Vector3 startScale;

    private void Awake()
    {
        startPos = transform.position;
        startScale = transform.localScale;
    }

    private void Update()
    {
        // Spin (circle ise görsel olarak fark edilmeyebilir)
        transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);

        // Float
        float yOffset = Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.position = new Vector3(startPos.x, startPos.y + yOffset, startPos.z);

        // Pulse
        float p = 1f + Mathf.Sin(Time.time * pulseFrequency) * pulseAmplitude;
        transform.localScale = startScale * p;
    }
}
