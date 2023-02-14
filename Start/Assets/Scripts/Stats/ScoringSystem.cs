using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreValue;
    public int tScore;
    public AudioSource pickUpSound;

    void onTriggerEnter(Collider other)
    {
        pickUpSound.Play();
        tScore += 50;
        scoreValue.GetComponent<Text>().text = "Points: " + tScore;
        Destroy(gameObject);
    }
}
