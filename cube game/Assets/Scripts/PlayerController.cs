using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float xAxisForce;
    [SerializeField] private float forwardForce;
    bool leftKey, rightKey;


    private void Update()
    {
        //leftKey = Input.GetKeyDown(KeyCode.A);
        //rightKey= Input.GetKeyDown(KeyCode.D);

        leftKey = Input.GetKey("a");
        rightKey = Input.GetKey("d");
        Movement();
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        //add force to the x axis
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    rb.AddForce(xAxisForce * Time.deltaTime, 0, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    rb.AddForce(-xAxisForce * Time.deltaTime, 0, 0);
        //}

    }
    void Movement()
    {
        if (rightKey)
        {
            rb.AddForce(xAxisForce * Time.deltaTime, 0, 0);
        }

        if (leftKey)
        {
            rb.AddForce(-xAxisForce * Time.deltaTime, 0, 0);
        }

    }

}
