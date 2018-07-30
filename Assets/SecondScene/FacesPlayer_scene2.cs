using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacesPlayer_scene2 : MonoBehaviour {


    public float rotSpeed = 90f;
    Transform player;
    //MoveForward_bossy MoveScript;
    BossyShoot shootScript;
    int boss_flag;

    // Use this for initialization
    private void Start()
    {
            
       // MoveScript = this.GetComponent<MoveForward_bossy>();
        shootScript = this.GetComponent<BossyShoot>();

    }
    // Update is called once per frame
    void Update()
    {
        boss_flag = shootScript.ult_flag;


        //If Flag = 1 -> Initiate Ulti -> stop facing player
        /*if (boss_flag == 1)
        {
            this.enabled = false;

        }*/



            // Player is dead, find him
            if (player == null)
        {
            GameObject go = GameObject.Find("Player_scene2");


            if (go != null)
            {
                player = go.transform;
            }

        }


        // We found Player or he doesnt exist

        if (player == null)
        {
            return;
        }
        if (boss_flag == 0)
        {


            Vector3 dir = player.position - transform.position;
            dir.Normalize();

            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

            Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);



        }
    }
}


