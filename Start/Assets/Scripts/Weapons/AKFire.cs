using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class AKFire : MonoBehaviour
{
    public KeyCode fireKey = KeyCode.Mouse0;
    public GameObject theAK;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
    public float fireRate;
    public AudioSource emptyCLick;
    public float targetDistance;
    public int damageAmount;
    public Transform shotOrigin;

    public DamageConfigScriptableObject DamageConfig;


    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            if(AmmoGlobal.aKAmmo < 1)
            {
                emptyCLick.Play();
            }
            else
            {
                if (isFiring == false)
                {
                    StartCoroutine(FiringAK());
                }
            }
        }
    }
    IEnumerator FiringAK()
    {
        RaycastHit shot;
        isFiring = true;

        
        var transformDir = shotOrigin.TransformDirection(Vector3.forward);
        Debug.DrawRay(shotOrigin.position, transformDir * 100, Color.green, 10, false);
        if (Physics.Raycast(shotOrigin.position, transformDir, out shot))
        {
            if (shot.collider.TryGetComponent(out TDanage damagable))
            {
                targetDistance = shot.distance;
                damagable.TakeDamage(DamageConfig.GetDamage(targetDistance));
            }
            targetDistance = shot.distance;
        }
        
        theAK.GetComponent<Animator>().Play("AkFire");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(fireRate);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(fireRate);
        theAK.GetComponent<Animator>().Play("New State");
        isFiring =false;
        AmmoGlobal.aKAmmo -= 1;
    }
}
