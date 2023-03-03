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
    public static int deathCount;
    public void TakeDamage(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }
    void Update()
    {
        if(enemyHealth <= 0 && enemyDead == false)
        {
            StartCoroutine(Die());
        }
    }
    private IEnumerator Die() 
    {
        enemyDead = true;
        explosion.GetComponent<ParticleSystem>().Play();
        
        enemyAI.SetActive(false);
        yield return new WaitForSeconds(explosion.GetComponent<ParticleSystem>().main.duration);
        deathCount++;
        Destroy(gameObject);
    }
}

