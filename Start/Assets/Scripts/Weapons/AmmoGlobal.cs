using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoGlobal : MonoBehaviour
{
    public static int aKAmmo;
    public GameObject ammoDisplay;

    void Update()
    {
        ammoDisplay.GetComponent<Text>().text = "" + aKAmmo;
    }
}
