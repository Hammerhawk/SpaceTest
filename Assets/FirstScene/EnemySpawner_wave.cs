using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner_wave : MonoBehaviour {

    public GameObject enemyPrefab;
    public float enemyRate = 5f;
    public float firstEnemy = 0f;    //time till first spawn
    LevelData scriptData;
    private void Start()
    {
        GameObject x = GameObject.FindGameObjectWithTag("MainCamera");
        scriptData = x.GetComponent<LevelData>();
    }

    // Update is called once per frame
    void Update () {


        if (scriptData.transition_time <= 0)
        {
            this.enabled = false;

        }
        firstEnemy -= Time.deltaTime;

        if (firstEnemy <= 0)
        {
            firstEnemy = enemyRate;

            Quaternion rot =  Quaternion.Euler( 0, 0, 180);

            Instantiate(enemyPrefab, transform.position + new Vector3(7, 0, 0), Quaternion.identity * rot);
            Instantiate(enemyPrefab, transform.position + new Vector3(3, 0, 0), Quaternion.identity * rot);
            Instantiate(enemyPrefab, transform.position + new Vector3(-3, 0, 0), Quaternion.identity* rot);
            Instantiate(enemyPrefab, transform.position + new Vector3(-7, 0, 0), Quaternion.identity* rot); 
            
        }
    }
}

