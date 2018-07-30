using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    int bulletLayer;

    public float fireDelay = 0.5f;
    float cooldownTimer = 0;

    Transform player;

    void Start()
    {

        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {

        cooldownTimer -= Time.deltaTime;


        GameObject go = GameObject.Find("Player1");
        if (go != null )
        {
            player = go.transform;


        }

        if ( cooldownTimer <= 0 && Vector3.Distance(transform.position, player.position) < 15)
        {
            Debug.Log("Pew");

            cooldownTimer = fireDelay;
            //Shoot

            Vector3 offset = transform.rotation * bulletOffset;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;

        }

    }
}
