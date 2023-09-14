using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W key pressed");
            transform.position += Vector3.back;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S key pressed");
            transform.position += Vector3.forward;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key pressed");
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D key pressed");
            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q key pressed");
            transform.position += Vector3.up;
        }


    }
}