using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //private variables
    private float speed = 0;
    private float turnSpeed = 15;
    private float jumpSpeed = 10;
    private float horizontalInput;
    private float verticalInput;
    private float jumpInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");
        


        // change speed depending on player input
        if (Input.GetKeyDown("w")) {
            speed = 10;
        }
        if (Input.GetKeyUp("w")) {
            speed = 0;
        }

        // uses input to move vehicle back or forwad
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //       transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);


        // if speed is greater than 0, then horizontal axis will rotate the vehicle
        if (speed > 0) {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * turnSpeed * horizontalInput);
        }

        // jumping input for funs.
        transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed * jumpInput);


    }


}
