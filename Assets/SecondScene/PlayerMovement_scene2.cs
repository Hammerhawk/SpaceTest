using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_scene2 : MonoBehaviour
{


    public float maxSpeed = 15f;
    public float rotSpeed = 180f;
    float shipBoundaryRadius = 1f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Rotate The Ship

        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime * -1;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        //Move the Ship
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        //pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

        pos += rot * velocity;



        transform.position = pos;

        // Alternative:
        // transform.Translate(new Vector3(0, Input.GetAxis("Vertica") * maxSpeed *Time.deltaTime, 0));








    }
}


