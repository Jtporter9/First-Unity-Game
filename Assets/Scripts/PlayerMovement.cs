using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidwaysForce = 600f;

    // Use this for initialization
    void Start ()
    {

	}

    // Update is called once per frame 
    private void Update()
    {
        
    }

    // Use FixedUpdate for Physics
    void FixedUpdate ()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
