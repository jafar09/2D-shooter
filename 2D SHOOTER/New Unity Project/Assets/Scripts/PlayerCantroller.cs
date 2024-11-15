using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCantroller : MonoBehaviour
{
    // Private Variables
    private float speed = 5.0f; 
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
        // This is where we get player input 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        // we move the vihicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // we turn the vehicle 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
