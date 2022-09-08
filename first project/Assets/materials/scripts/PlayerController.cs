using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    // Access Mod, Data Type, Name ;
    public float speed; // set speed value
    public float rotSpeed; // Rotation
    public float hInput; // horizontal input
    public float vInput; //vetical input
    public float jumpForce; // jummp height
    public Rigidbody playerRB; // Reference Rigidbody component

    // Update is called once per frame 
    void Update()
    {
        // Collect Input values from keyboard
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //move character
        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime);
         
        //left and right movement
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime); //forward backward movement
         
        if(Input.GetkKeyDown(KeyCode.Space)) // Check for space bar press
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Makes player Jump
         
    }
}
