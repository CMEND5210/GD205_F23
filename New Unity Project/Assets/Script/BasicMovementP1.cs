using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovementP1 : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards;
    Vector3 startPos;
    public AudioClip death;
    AudioSource audPlayer;

    void Start()
    {
        startPos = transform.position;
        audPlayer = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("The Q Key was pressed.");

            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("The A Key was pressed.");

            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("The W Key was pressed.");

            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("The S Key was pressed.");

            transform.position += Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("The E Key was pressed.");

            transform.position += Vector3.forward;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("The D Key was pressed.");

            transform.position += Vector3.back;
        }

        for (int i = 0; i < hazards.Length; i++)
        {
            if (transform.position == hazards[i].transform.position)
            {
                transform.position = startPos;
                audPlayer.PlayOneShot(death, 0.75F);
            }
        }
    }
}
