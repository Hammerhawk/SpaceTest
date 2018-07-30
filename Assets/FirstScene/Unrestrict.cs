using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unrestrict : MonoBehaviour {

    public float free_timer = 10.0f;
    float timer;
    GameObject spawn;
    LevelData playtime;

    // Use this for initialization
    void Start () {
        spawn = GameObject.FindGameObjectWithTag("MainCamera");
        playtime = spawn.GetComponent<LevelData>();
    }

    // Update is called once per frame
    void Update () {

        timer = playtime.levelTime;

        if ( timer  >= free_timer)
        {
            this.GetComponent<PlayerMovement_restricted>().enabled = false;
            this.GetComponent<PlayerMovement>().enabled = true;
            this.enabled = false;
            return;
        }
		
	}
}
    