using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemyPrefab;
    public float spawnDistance = 5f;
    public float enemyRate = 0.1f;
    float level_time;
    float nextEnemy;    //time till next enemy appears
    LevelData scriptData;

    private void Start()
    {
        GameObject x  = GameObject.FindGameObjectWithTag("MainCamera");
        scriptData = x.GetComponent<LevelData>();

    }
    // Update is called once per frame
    void Update () {

        nextEnemy -= Time.deltaTime;
        level_time = scriptData.levelTime;

        if (nextEnemy <= 0)
        {
            nextEnemy = enemyRate;
            enemyRate *= 0.9f;
            if (enemyRate < 1) enemyRate = 1;

            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;
            offset = offset.normalized * spawnDistance;
            Quaternion rot = Quaternion.Euler(0, 0, 180);

            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity*rot );
        }

        if (level_time <= 0) this.enabled = false;
    }
}
