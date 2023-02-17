using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
[RequireComponent(typeof(TDanage))]
public class SpawnParticleOnDeath : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem DeathSystem;
    public TDanage Damagable;

    private void Awake()
    {
        Damagable = GetComponent<TDanage>();
    }

    private void OnEnable()
    {
        Damagable.onDeath += Damagable_onDeath;
    }

    private void Damagable_onDeath(Vector3 Position)
    {
        Instantiate(DeathSystem, Position, Quaternion.identity);
    }
}
