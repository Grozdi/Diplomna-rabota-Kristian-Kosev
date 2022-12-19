using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKFire : MonoBehaviour
{
    public KeyCode fireKey = KeyCode.Mouse0;
    public GameObject theAK;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
    public float fireRate;


    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            if(isFiring == false)
            {
                StartCoroutine(FiringAK());
            }
        }
    }
    IEnumerator FiringAK()
    {
        isFiring = true;
        theAK.GetComponent<Animator>().Play("AkFire");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(fireRate);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(fireRate);
        theAK.GetComponent<Animator>().Play("New State");
        isFiring =false;
    }
}