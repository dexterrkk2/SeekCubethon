using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            gameManager.CompleteLevel();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
