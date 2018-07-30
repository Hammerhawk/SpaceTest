using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelData : MonoBehaviour {



    public float levelTime = 0.0f;      //Level Duration to trigger events
    public float game_time = 0.0f;      //Simply Tracks Time
    public float transition_time = 0.0f;
    public float next_level_time;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        game_time += Time.deltaTime;
        levelTime -= Time.deltaTime;


        if (levelTime <= 0)
        {
            transition_time -= Time.deltaTime;

        }

       

        if (transition_time <= 0)
        {
            next_level_time -= Time.deltaTime;
             
        }

        if (next_level_time <= 0)
        {

            SceneManager.LoadScene("SecondScene");
        }

    }

}
