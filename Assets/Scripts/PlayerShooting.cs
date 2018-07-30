using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    int bulletLayer;


    // Update is called once per frame

    void Start()
    {

        bulletLayer = gameObject.layer;
    }
    void Update () {

        cooldownTimer -= Time.deltaTime;


        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
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
