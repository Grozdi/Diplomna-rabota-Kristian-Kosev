using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_47_Pick_Up : MonoBehaviour
{
    public GameObject realAK;
    public GameObject fakeAK;
    public AudioSource akPickupSound;

    void OnTriggerEnter(Collider other)
    {
        realAK.SetActive(true);
        fakeAK.SetActive(false);
        akPickupSound.Play();
    }

}
