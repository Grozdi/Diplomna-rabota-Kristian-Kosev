using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierLookAround : MonoBehaviour
{
    public Transform mainPlayer;

    void Update()
    {
        transform.LookAt(mainPlayer);
    }
}
