using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward_bossy : MonoBehaviour
{

    public float maxSpeed = 5f;
    int ult_flag;

    //public float ulty_cd_time;
    BossyShoot ShootScript;


    // Update is called once per frame

    private void Start()
    {

        ShootScript = this.GetComponent<BossyShoot>();
    }
    void Update()
    {


        ult_flag = ShootScript.ult_flag;


        // just rotation, no shooting
        if (ult_flag == 1)
        {
           

            transform.Rotate(0, 0, Time.deltaTime * 100);
         
        }

        // if no ulty, just move towards player
        if (ult_flag == 0)
        {
            Vector3 pos = transform.position;

            Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

            pos += transform.rotation * velocity;
            transform.position = pos;
        }



        }
    }

