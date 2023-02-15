using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collision)
    {
        if (!(collision.collider.name == "Ground"))
        {
            movement.enabled = false;
            gameManager.EndGame();
        }
        else
            PlayerMovement.isCollidedGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        PlayerMovement.isCollidedGround = false;
    }
}
