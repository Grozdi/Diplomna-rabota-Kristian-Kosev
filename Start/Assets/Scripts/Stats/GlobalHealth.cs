using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using System.IO;

public class GlobalHealth : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;
    void Start()
    {
        healthValue = 100;
    }
    void Update()
    {
        if(healthValue <= 0)
        {
            SceneManager.LoadScene(0);
        }
        healthDisplay.GetComponent<Text>().text = "" + healthValue;
    }
}
