using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [Header("Player Stats")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera Info")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;
    [Header("Private Variables")]
    private Camera camera;
    private Rigidbody rb;
    void Awake()
    {
        //Get Components 
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
        //freeze cursor
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraLook();
        //jump
        if (Input.GetButtonDown("Jump"))
            PlayerJump();
    }

  

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //move left and right
        float z = Input.GetAxis("Vertical") * moveSpeed; //move backward and forward

        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;

        rb.velocity = dir; // applies velocity on x and y axis
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void PlayerJump()
    {
        //ground detection
        Ray ray = new Ray(transform.position, Vector3.down);
        //jump ability
        if (Physics.Raycast(ray, 1.1f))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }

    public void GiveHealth(int amount)
    {

    }

    public void GiveAmmo(int amount)
    {

    }
}
