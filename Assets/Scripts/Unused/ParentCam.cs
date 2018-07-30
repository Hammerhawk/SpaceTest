using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCam : MonoBehaviour {


    public GameObject playerCamPrefab;

    GameObject playerCam;

    //public GameObject playerInstance;
    //GameObject ship = 

    // Use this for initialization

    void Start () {
        playerCam = (GameObject)Instantiate(playerCamPrefab);
        playerCam.transform.parent = gameObject.transform;
        //playerInstance.transform;


        //this.gameObject.GetComponent<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {

        if (playerCam == null) { 
        playerCam = (GameObject)Instantiate(playerCamPrefab);
        playerCam.transform.parent = gameObject.transform;
        }
    }
}







        //playerCam2.SetActive(true);

        //GameObject ship = GameObject.Find("Player1");




        //Camera playerCam = Camera.Instantiate(player
        //      ,transform.position, Quaternion.identity);

        //GameObject playerCam = GameObject.FindGameObjectWithTag("PlayerCam");

        //playerCam.transform.parent = ship.transform;