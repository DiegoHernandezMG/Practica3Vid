using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject PrefabProjectile;
    // Punto de spawneo del proyectil
    public Transform SocketProjectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject proj = GameObject.Instantiate(PrefabProjectile, SocketProjectile.position, SocketProjectile.rotation);
            proj.name = "PlayerProjectile";
            proj.transform.rotation = transform.rotation;
        }
    }
}
