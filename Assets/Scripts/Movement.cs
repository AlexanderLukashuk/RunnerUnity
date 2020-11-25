using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 20;
    public int speedRight = 15;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        rb.AddForce(0, 0, speed);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-speedRight, 0, 0);
            
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(speedRight, 0, 0);

        if (transform.position.y < -5)
            Application.LoadLevel(Application.loadedLevel);
    }
}
