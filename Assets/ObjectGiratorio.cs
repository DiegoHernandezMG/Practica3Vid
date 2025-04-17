using UnityEngine;

public class OrbitalEffect : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float scaleAmplitude = 0.5f; // cuánta escala cambia
    public float scaleFrequency = 2f;    // velocidad del pulso
    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Rotación en el eje Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

        // Escalado tipo "pulso" (pero sin movimiento en eje Y)
        float scaleOffset = Mathf.Sin(Time.time * scaleFrequency) * scaleAmplitude;
        transform.localScale = initialScale + new Vector3(scaleOffset, scaleOffset, scaleOffset);
    }
}