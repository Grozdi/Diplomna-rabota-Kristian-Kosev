using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookAtPlayer = false;
    public GameObject enemy;

    void Update()
    {
        RaycastHit enemyDamage;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out enemyDamage))
        {
            hitTag = enemyDamage.transform.tag;
        }
        if (hitTag == "Player")
        {
            lookAtPlayer = true;
            enemy.GetComponent<Animator>().Play("demo_combat_shoot");
        }
        else
        {
            lookAtPlayer = false;
            enemy.GetComponent<Animator>().Play("demo_combat_idle");
        }
    }
}
