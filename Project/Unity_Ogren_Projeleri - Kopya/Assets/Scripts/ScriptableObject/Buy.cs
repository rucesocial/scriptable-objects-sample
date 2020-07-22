using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Assets.Scripts.ScriptableObject;
using System;
public class Buy : MonoBehaviour
{
    private PlayerData playerData;
    private void Start()
    {
        WriteOrReadFile();
    }
    private void WriteOrReadFile()
    {
        string path = Application.persistentDataPath + "/playerdata.json";

        if (!File.Exists(path))
        {
            Debug.Log("Dosya yok");
            FileStream fs = File.Create(path);
            fs.Close();

            string json = JsonUtility.ToJson(playerData, true);

            File.WriteAllText(path, json);
        }


    }
}
