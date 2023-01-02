using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distancheTarget;
    public float distancheUntilTarget;
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            distancheUntilTarget = hit.distance;
            distancheTarget = distancheUntilTarget;
        }
    }
}
