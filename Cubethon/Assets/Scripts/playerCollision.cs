using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement playerMvmnt;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "Enemy")
        {
            playerMvmnt.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
