using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player be able to use movement button
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // To make the vehicle move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Smooth turning like a car
        transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed * horizontalInput);
    }
}
