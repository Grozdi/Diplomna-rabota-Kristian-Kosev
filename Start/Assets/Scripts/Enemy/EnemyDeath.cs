using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public float enemyHealth;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject explosion;
    public GameObject enemy;

    void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }
    void Update()
    {
        if(enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            this.GetComponent<ParticleSystem>().Emit(0);
            enemyAI.SetActive(false);
        }
    }
}
