using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{

    Rigidbody rb;
    public float forceMultiplier = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(-transform.right * forceMultiplier);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * forceMultiplier);
        }

        if (Input.GetKey(KeyCode.E))
        {
            rb.AddForce(transform.forward * forceMultiplier);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * forceMultiplier);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * forceMultiplier);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-transform.forward * forceMultiplier);
        }
    }

    void OnCollisionEnter(Collision ouch)
    {
        Debug.Log("An accident happened. ;)");
        rb.useGravity = true;
        GetComponent<ParticleSystem>().Play();
    }
}
