using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{

    public Transform cam;
    public Transform attackPoint;
    public GameObject grenade;

    public int throwNum;

    public KeyCode throwKey = KeyCode.G;
    public float tForce;
    public float upForce;
    public float throwCool;
    bool readyToThrow;


    private void Start()
    {
        readyToThrow = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(throwKey) && readyToThrow && throwNum > 0)
        {
            Throw();
        }
    }
    private void Throw()
    {
        
        readyToThrow = false;
        GameObject nade = Instantiate(grenade, attackPoint.position, cam.rotation);

        Rigidbody nadeRB = nade.GetComponent<Rigidbody>();
        nadeRB.AddForce((Vector3)(tForce * upForce * cam.transform.forward + transform.up), ForceMode.Impulse);

        throwNum--;
        Invoke(nameof(ResetThrow), throwCool);
    }

    private void ResetThrow()
    {
        readyToThrow = true;
    }

}
