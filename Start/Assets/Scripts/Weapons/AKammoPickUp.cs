using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AKammoPickUp : MonoBehaviour
{
    public GameObject fakeAmmoAK;
    public AudioSource ammoPickupSound;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmoAK.SetActive(false);
        ammoPickupSound.Play();
    }
}
