using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AK_47_Pick_Up : MonoBehaviour
{
    public GameObject realAK;
    public GameObject fakeAK;
    public AudioSource akPickupSound;
    public GameObject pickupDisplay;

    void OnTriggerEnter(Collider other)
    {
        realAK.SetActive(true);
        fakeAK.SetActive(false);
        akPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "Picked up AK-47";
        pickupDisplay.SetActive(true);
    }

}
