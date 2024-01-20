using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public float GetFace(Vector3 direction, float current)
    {
        if (direction.sqrMagnitude > 0)
        {
            return Mathf.Atan2(direction.x, direction.y);
        }
        else
        {
            return current;
        }
    }
}
