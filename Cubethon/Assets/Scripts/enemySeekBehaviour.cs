using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySeekBehaviour : MonoBehaviour
{
    public Face face;
    public Transform target;
    public Rigidbody rb;
    public bool isFleeing;
    public bool awake;
    public float maxSpeed;
    public float awakeTime;
    float timer;
    private void Start()
    {
        face = GetComponent<Face>();
        awake = false;
    }
    void SeekOrFlee()
    {
        Vector3 direction;
        if (isFleeing)
        {
            direction = new Vector3(transform.position.x - target.position.x, 0, transform.position.z - target.position.z);
        }
        else
        {
            direction = new Vector3(target.position.x - transform.position.x, 0, target.position.z - transform.position.z);
        }
        direction.Normalize();
        
        transform.Rotate(transform.position, face.GetFace(direction, 1f));
        rb.AddForce(direction * maxSpeed *Time.deltaTime);
    }
    private void FixedUpdate()
    {
        if(timer>= awakeTime)
        {
            awake = true;
        }
        if (awake)
        {
            SeekOrFlee();
        }
        timer += Time.deltaTime;
    }
}