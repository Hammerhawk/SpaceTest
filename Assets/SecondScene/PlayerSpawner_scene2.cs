﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner_scene2 : MonoBehaviour {


    public GameObject playerPrefab;
    GameObject playerInstance;

    public int numLives = 4;

    float respawnTimer;

	// Use this for initialization
	void Start () {
        SpawnPlayer();
    }
	

    void SpawnPlayer()
    {

        numLives -= 1;
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "Player_scene2";
    }

    // Update is called once per frame
    void Update () {


        if (playerInstance == null && numLives > 0)
   
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0) SpawnPlayer();

        }

	}

    private void OnGUI()
    {
        if(numLives > 0 || (playerInstance != null) )
        GUI.Label(new Rect(0, 0, 100, 50 ), "Lives Left: " + numLives);
        else GUI.Label(new Rect( Screen.width/2 -50 , Screen.height/ 2 - 25, 100, 50), "Game Over, Yo!");

    }

}
//self.AddComponent<PlayerMovement_restricted>();

//GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");
//ship.transform.parent = Camera.main.transform;