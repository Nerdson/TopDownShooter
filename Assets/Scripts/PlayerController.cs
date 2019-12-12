﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

<<<<<<< Updated upstream
    private float horizontalInput;

    private float forwardInput;

    private float verticalInput;

    public float speed = 10.0f;

    public float turnSpeed = 150.0f;

    public float xRange = 15.0f;

    public float zRange = 12.0f;

    public GameObject projectilePrefab;
=======
    public float horizontalInput;

    public float verticalInput;

    public float speed = 10.0f;

    public float xRange = 15.0f;

    public float zRange = 10.0f;
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // create boundaries for player
        if (transform.position.x < -xRange) {
            // if true keep x bound position
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) {
            // if true keep x bound position
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

<<<<<<< Updated upstream
        // create boundaries for player
=======
>>>>>>> Stashed changes
        if (transform.position.z < -zRange)
        {
            // if true keep z bound position
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            // if true keep z bound position
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        // get input from left and right arrow keys
        horizontalInput = Input.GetAxis("Horizontal");

        // Translate position on x-axis
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // get input from up and down arrow keys
<<<<<<< Updated upstream
        forwardInput = Input.GetAxis("Vertical");

        // Translate position on x-axis
        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);

        // get input from Q and E keys
        verticalInput = Input.GetAxis("Turn");

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * verticalInput);

        // if the left mouse button is pressed down, execute the if-statement inside the curly brackets
        if (Input.GetKeyDown("mouse 0")){
            // Launch Food from Player - clone projectile prefab and spawn at player position
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            Debug.Log("Food was shot");
        }
=======
        verticalInput = Input.GetAxis("Vertical");

        // Translate position on z-axis
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
>>>>>>> Stashed changes
    }
}
