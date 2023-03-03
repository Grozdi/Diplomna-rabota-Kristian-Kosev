using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFunc : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F10))
            SaveGame();
        if (Input.GetKeyDown(KeyCode.L))
            LoadGame();
    }

    private void SaveGame()
    {
        SaveData saveData = new SaveData();
        saveData.position = new SaveData.Position
        {
            x = transform.position.x,
            y = transform.position.y,
            z = transform.position.z
        };
        SaveMan.SaveGameState(saveData);
    }

    private void LoadGame()
    {
        SaveData saveData = SaveMan.LoadGameState();
        if (saveData != null)
        {
            transform.position = new Vector3(saveData.position.x, saveData.position.y, saveData.position.z);
        }
    }
}