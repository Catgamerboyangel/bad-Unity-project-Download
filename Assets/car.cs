using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody rb; // The car's Rigidbody component
    public float motorForce = 1500f; // Force applied to move the car forward
    public float turnSpeed = 5f; // Speed of turning/steering
    public float brakeForce = 3000f; // Force applied when braking
    public float maxSpeed = 50f; // Maximum speed of the car

    private float moveInput; // Input for forward/reverse movement
    private float turnInput; // Input for steering

    void Start()
    {
        // Get the car's Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get player input for movement and steering
        moveInput = Input.GetAxis("Vertical"); // W/S or Up/Down Arrow for forward/reverse
        turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow for steering
    }

    void FixedUpdate()
    {
        // Limit car's speed to prevent excessive speed
        if (rb.velocity.magnitude < maxSpeed)
        {
            // Apply force for forward/reverse movement
            rb.AddForce(transform.forward * moveInput * motorForce * Time.deltaTime);
        }

        // Steer the car
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);

        // Brake when not accelerating
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(-rb.velocity * brakeForce * Time.deltaTime); // Apply brake force
        }
    }
}
