using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000;
    public float xForce = 500;

    void Start()
    {

    }
    // We use FixedUpdate here because we are using Unity's Physics engine
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d")) {
            rb.AddForce(xForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-xForce * Time.deltaTime, 0, 0);
        }
    }
}
