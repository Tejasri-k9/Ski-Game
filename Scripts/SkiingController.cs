using UnityEngine;

public class SkiingController : MonoBehaviour
{
    public float forwardSpeed = 5f; // Speed of automatic forward movement
    public float turnSpeed = 2f;    // Turning speed

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody component
    }

    void Update()
    {
        // Move forward automatically
        Vector3 forwardMove = transform.forward * forwardSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + forwardMove);

        // Get left/right input (A/D or Left/Right arrows)
        float turn = Input.GetAxis("Horizontal") * turnSpeed;
        transform.Rotate(Vector3.up * turn * Time.deltaTime * 50);
    }
}

