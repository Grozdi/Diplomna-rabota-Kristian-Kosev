using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, TDanage
{
    [SerializeField]
    private int MaxHealth = 100;
    [SerializeField]
    private int Health;

    public int currHP { get => Health; private set => Health = value; }

    public int maxHP { get => MaxHealth; private set => MaxHealth = value; }

    public event TDanage.TakeDamageEvent onTakeDamage;
    public event TDanage.DeathEvent onDeath;

    private void onEnable() { 

        currHP = maxHP;
}

    public void TakeDamage(int Damage)
    {
        int dmgTaken = Mathf.Clamp(Damage, 0, currHP);
        currHP -=dmgTaken;
        if(dmgTaken != 0)
        {
            onTakeDamage?.Invoke(dmgTaken);
        }
        if(currHP == 0 && dmgTaken != 0)
        {
            onDeath?.Invoke(transform.position);
        }
    }
}
