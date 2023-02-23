using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bullSpeed;

    void Update()
    {
        transform.Translate(0.0f, 0.0f, bullSpeed * Time.deltaTime);
    }

    void onTriggerEnter(Collider other)
    {

    }
}
