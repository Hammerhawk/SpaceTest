using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_restricted : MonoBehaviour
{

    public float maxSpeed = 15f;
    public float rotSpeed = 180f;
    float extra_time;
    float shipBoundaryRadius = 1f;
    float time;
    LevelData spawnScript;


    // Use this for initialization
    void Start()
    {
        GameObject x = GameObject.FindGameObjectWithTag("MainCamera");
        spawnScript = x.GetComponent<LevelData>();
        extra_time = spawnScript.transition_time; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        time = spawnScript.levelTime;

        Debug.Log("RESTRICTED TIME");
        
        if (time <= 0  )
        {
            extra_time -= Time.deltaTime;

            if ( extra_time  <= 0) { 
            pos.y += (0-pos.y) * 2 * Time.deltaTime;
            pos.x += (0 - pos.x) * 2 * Time.deltaTime;
            }


        }
        
        //Move the Ship

       // Vector3 velocity = new Vector3(Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
       if (extra_time  >= 0)
        { 
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        }

        // Restrict the player  to camera's boundaries

        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
       {
           pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
       }
       if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
       {
           pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
       }
        
       float screenRatio = (float)Screen.width / (float)Screen.height; // Will be weird
       float widthOrtho = Camera.main.orthographicSize * screenRatio;

       if (pos.x + shipBoundaryRadius > widthOrtho)
       {
           pos.x = widthOrtho - shipBoundaryRadius;
       }
       if (pos.x - shipBoundaryRadius < -widthOrtho)
       {
           pos.x = -widthOrtho + shipBoundaryRadius;
       }

   
        transform.position = pos;

        // Alternative:
        // transform.Translate(new Vector3(0, Input.GetAxis("Vertica") * maxSpeed *Time.deltaTime, 0));








    }
}


//Rotate The Ship

/*
Quaternion rot = transform.rotation;
float z = rot.eulerAngles.z;
z += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime * -1;
rot = Quaternion.Euler(0, 0, z);
transform.rotation = rot;
*/
//pos += rot * velocity;
