using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEnemy : MonoBehaviour
{
    Rigidbody br;
    public Transform player;
    public float forceMultiplier = 4f;

    // Start is called before the first frame update
    void Start()
    {
        br = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        br.AddForce(Vector3.Normalize(player.position - transform.position) * forceMultiplier);
    }
}
