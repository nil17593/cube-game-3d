using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float xAxisForce;
    [SerializeField] private float forwardForce;
    [SerializeField] GameObject gameOver;
    bool leftKey, rightKey;


    private void Update()
    {
        leftKey = Input.GetKey("a");
        rightKey = Input.GetKey("d");
        Movement();
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
    }
    void Movement()
    {
        if (rightKey)
        {
            rb.AddForce(xAxisForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }

        else if (leftKey)
        {
            rb.AddForce(-xAxisForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if (rb.position.y < -1)
        {
            gameOver.SetActive(true);
        }
    }

}
