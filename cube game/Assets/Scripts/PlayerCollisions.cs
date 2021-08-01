using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [HideInInspector] public bool gameover = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            playerController.enabled = false;
            gameover = true;
        }
    }
}
