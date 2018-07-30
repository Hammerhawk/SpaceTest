using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public Transform myTarget;

    GameObject go;

    // Update is called once per frame
    private void Start()
    {
         go = GameObject.Find("Player_scene2");
    }
    void Update ()
    {


        if ( go != null)
        {
            
            Vector3 target_pos = go.transform.position;
            target_pos.z = transform.position.z;
            transform.position = target_pos;
        }
        else go = GameObject.Find("Player_scene2");


        /*

        if (myTarget != null)
        {
            Vector3 targetPos = myTarget.position;
            targetPos.z = transform.position.z;
            // consider Vector3.Lerp for  neat effects;
            transform.position = targetPos;
        }
        */
    }
        
}

