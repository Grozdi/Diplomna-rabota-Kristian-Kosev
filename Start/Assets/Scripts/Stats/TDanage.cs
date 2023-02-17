using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface TDanage 
{
    public int currHP { get; }
    public int maxHP { get; }

    public delegate void TakeDamageEvent(int Damage);
    public event TakeDamageEvent onTakeDamage;

    public delegate void DeathEvent(Vector3 Position);
    public event DeathEvent onDeath;

    public void TakeDamage(int Damage)
    {
        Damage = 30;
    }
}
