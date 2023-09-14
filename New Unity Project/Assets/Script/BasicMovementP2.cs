using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementP2 : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("The O Key was pressed.");

            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("The L Key was pressed.");

            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("The I Key was pressed.");

            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("The K Key was pressed.");

            transform.position += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("The U Key was pressed.");

            transform.position += Vector3.forward;

        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("The J Key was pressed.");

            transform.position += Vector3.back;
        }
    }
}
