using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookAtPlayer = false;
    public GameObject enemy;
    public AudioSource enemyFire;
    public bool isFiring = false;
    public float fireRate;
    public int genHurt;
    public AudioSource[] hurtSound;
    public GameObject hurtScreen;
    public EnemyHealth Health;


    

    void Update()
    {
        RaycastHit enemyDamage;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out enemyDamage))
        {
            hitTag = enemyDamage.transform.tag;
        }
        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(Fire());
        }
        if (hitTag != "Player")
        {
            lookAtPlayer = false;
            enemy.GetComponent<Animator>().Play("demo_combat_idle");
        }
    }
    IEnumerator Fire()
    {
        isFiring = true;
        lookAtPlayer = true;
        enemyFire.Play();
        enemy.GetComponent<Animator>().Play("demo_combat_shoot", -1, 0);
        enemy.GetComponent<Animator>().Play("demo_combat_shoot");
        GlobalHealth.healthValue -= 5;
        hurtScreen.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        hurtScreen.SetActive(false);
        genHurt = UnityEngine.Random.Range(0, 3);
        hurtSound[genHurt].Play();
        yield return new WaitForSeconds(fireRate);
        isFiring=false;
    }
}
