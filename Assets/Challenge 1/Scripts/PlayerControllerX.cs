using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 8.0f;
    private float rotationSpeed = 100.0f;
    private float verticalInput;
    private float horizontalInput;
    //rigidBody reference
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //get the rigidbody reference. This will enable control over performance of rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed * verticalInput);
        //rotate the plane based on right/left arrow keys
        transform.Rotate(Vector3.back * Time.deltaTime * rotationSpeed * horizontalInput);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //freeze this gameObject upon colliding with an obstacles
        rb.freezeRotation = true;
    }
}
