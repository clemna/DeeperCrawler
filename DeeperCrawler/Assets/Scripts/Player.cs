﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;

public class Player : MonoBehaviour {

    public string Name;
    public int Level;
    public int HP;

    void Save() {
        JSONObject playerJson = new JSONObject();
        playerJson.Add("Name", Name);
        playerJson.Add("Level", Level);
        //BARS
        playerJson.Add("HP", HP);
        //POSITION
        JSONArray position = new JSONArray();
        position.Add(transform.position.x);
        position.Add(transform.position.y);
        position.Add(transform.position.z);
        playerJson.Add("Position", position);

        //SAVE JSON IN COMPUTER
        string path = Application.persistentDataPath + "/PlayerSave.json";
        File.WriteAllText(path, playerJson.ToString());

        Debug.Log(playerJson.ToString());

    }

    void Load() {
        string path = Application.persistentDataPath + "/PlayerSave.json";
        string jsonString = File.ReadAllText(path);
        JSONObject playerJson = (JSONObject)JSON.Parse(jsonString);
        //SET VALUES
        Name = playerJson["Name"];
        Level = playerJson["Level"];
        //BARS
        HP = playerJson["HP"];
        //POSITION
        transform.position = new Vector3(
            playerJson["Position"].AsArray[0],
            playerJson["Position"].AsArray[1],
            playerJson["Position"].AsArray[2]
        );
    }
    
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.S)) Save();
        if (Input.GetKeyDown(KeyCode.L)) Load();
    }
}
