using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossySpawnLoop : MonoBehaviour {

    public GameObject bossyPrefab1;
    public GameObject bossyPrefab2;
    public float spawnDistance;
    public float bossCounty;
    // Use this for initialization
    void Start () {

        for ( int i = 1; i <= bossCounty; i++)
        {
           
            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;
            offset = offset.normalized * spawnDistance;
            Quaternion rot = Quaternion.Euler(0, 0, 180);
            //+offset
            
            Vector3 h = transform.position + offset;
            h.z = 0;

            if (i % 2 == 0)
            {
                Instantiate(bossyPrefab1, h, Quaternion.identity * rot);
            }
            else
            {
                Instantiate(bossyPrefab2, h, Quaternion.identity * rot);
            }
            

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
