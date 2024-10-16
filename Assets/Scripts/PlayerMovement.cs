using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // rb refers to the rigidbody(physics)
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public Camera cam;
    float FOV;

    void Start()
    {
        Debug.Log(cam.fieldOfView);
    }
    // Fixed update is used because we are handling physics and unity likes that :)
    void FixedUpdate()
    {
        // forwardForce is the force at which the player is propelled in the z axis
        rb.AddForce(0, 0,forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
            // only executed *if* condition is met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) 
        {
            // only executed *if* condition is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
    void Update()
    {
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame(); // EndGame Function
        }
        if (Input.GetKey("w"))
        {
            FOV = cam.fieldOfView = cam.fieldOfView * 0.9f + 7f;
            
        }
        else
        {
            FOV = cam.fieldOfView = cam.fieldOfView * 0.9f + 5f;
        }
        
        cam.fieldOfView = FOV;
    }
}
