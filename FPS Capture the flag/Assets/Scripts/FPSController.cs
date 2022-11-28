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
    public float rotX;
    [Header("Private Variables")]
    private Camera camera;
    private Rigidbody rb;
    void Awake()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //move left and right
        float z = Input.GetAxis("Vertical") * moveSpeed; //move backward and forward
        rb.velocity = new Vector3(x, rb.velocity.y, z); // applies velocity on x and y axis
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse x") * lookSensitivity;
        rotX += Input.GetAxis("Mouse y") * lookSensitivity;
    }
}
