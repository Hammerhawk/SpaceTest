using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossyShoot : MonoBehaviour {

    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public GameObject ultyPrefab;
    int bulletLayer;

    public float ulty_timer;
    public float ulty_duration = 3.0f;
    public int ult_flag = 0;
 


    float ulty_cd_time_local;
    float ulty_duration_local;


    public float fireDelay = 0.5f;
    float cooldownTimer = 0;

    Transform player;

    void Start()
    {

        ulty_cd_time_local = ulty_timer;
        ulty_duration_local = ulty_duration;
        bulletLayer = gameObject.layer;


    }

    // Update is called once per frame
    void Update()
    {
        ulty_timer -= Time.deltaTime;

        cooldownTimer -= Time.deltaTime;
        GameObject go = GameObject.Find("Player_scene2");
        if (go != null )
        {
            player = go.transform;
        }

        if ( cooldownTimer <= 0 && Vector3.Distance(transform.position, player.position) < 100)
        {
            Debug.Log("Pew");

            cooldownTimer = fireDelay;
            //Shoot
            Vector3 offset = transform.rotation * bulletOffset;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;
        }

        if (ulty_timer <= 0)
        {

            ult_flag = 1;
            ulty_duration -= Time.deltaTime;

            Vector3 offset_ult = transform.rotation * bulletOffset;
            GameObject ulty_bulletGO = (GameObject)Instantiate(ultyPrefab, transform.position + offset_ult, transform.rotation);
        }
            if (ulty_duration <= 0)
            {
                ult_flag = 0;
                ulty_timer = ulty_cd_time_local;
                ulty_duration = ulty_duration_local;


            }
        }
    }

