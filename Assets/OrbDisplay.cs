using UnityEngine;

public class OrbDisplay : MonoBehaviour
{
    public float rotationSpeed = 30f;         // Velocidad de rotación
    public float pulseSpeed = 2f;             // Velocidad de pulso
    public float pulseAmount = 0.1f;          // Qué tanto crece y disminuye (escala)

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Rotar suavemente en el eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);

        // Hacer efecto de pulso (escala)
        float scaleOffset = Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
        transform.localScale = originalScale + Vector3.one * scaleOffset;
    }
}