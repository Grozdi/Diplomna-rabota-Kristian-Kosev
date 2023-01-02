using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AKammoPickUp : MonoBehaviour
{
    public GameObject fakeAmmoAK;
    public AudioSource ammoPickupSound;
    public GameObject pickupDisplay;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmoAK.SetActive(false);
        ammoPickupSound.Play();
        AmmoGlobal.aKAmmo += 30;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "Picked up AK ammo";
        pickupDisplay.SetActive(true);
 
    }
}
