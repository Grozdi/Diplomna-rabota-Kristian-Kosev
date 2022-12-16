using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    public GameObject door;
    public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        
        door.GetComponent<Animator>().Play("Door_Open");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
        doorFX.Play();
    }
        

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        
        door.GetComponent<Animator>().Play("Door_Close");
        this.GetComponent<BoxCollider>().enabled = true;
        doorFX.Play();

    }
}
