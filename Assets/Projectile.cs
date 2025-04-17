using UnityEditor.Rendering.Analytics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 3;
    float currentLifetime = 0;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // La rotación del proyectil indica su velocidad
        transform.Translate(Vector3.forward * speed);
        currentLifetime += Time.deltaTime;

        if(currentLifetime > lifetime)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
