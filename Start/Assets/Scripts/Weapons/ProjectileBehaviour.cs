using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public int damage;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void onCollisionEnter(Collision collision)
    {
      
        {
            
        }
        rb.isKinematic = true;

        transform.SetParent(collision.transform);
    }
}
