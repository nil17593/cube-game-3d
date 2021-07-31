using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 1000*Time.deltaTime);
    }
}
