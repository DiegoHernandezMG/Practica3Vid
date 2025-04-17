using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 CameraOffset = new Vector3(0, 0, 0);
    public Camera myCamera;

    public float moveSpeed = 5f;
    public float jumpSpeed = 5f;

    private Animator animator;

    void Start()
    {
        myCamera.transform.position = transform.position + CameraOffset;

        // Obtener el Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float deltaTime = Time.deltaTime;

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        // Movimiento
        transform.position += new Vector3(0, 0, inputZ * moveSpeed * deltaTime);
        transform.position += new Vector3(inputX * moveSpeed * deltaTime, 0, 0);

        // Salto
        var pos = transform.position;
        pos.y += Input.GetButton("Jump") ? jumpSpeed * deltaTime : 0;
        transform.position = pos;

        // Cámara
        if (myCamera != null)
        {
            myCamera.transform.position = transform.position + CameraOffset;
        }

        // Girar hacia la dirección del movimiento
        Vector3 movement = new Vector3(inputX, 0, inputZ);
        if (movement != Vector3.zero)
        {
            transform.forward = movement.normalized;
        }

        // Animación: usar la magnitud del movimiento
        if (animator != null)
        {
            float speed = movement.magnitude;
            animator.SetFloat("Speed", speed);
        }
    }
}