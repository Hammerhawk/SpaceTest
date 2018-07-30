using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagaHandler : MonoBehaviour {


    public int health = 1;
    public float invulnPeriod;
    public float invuln_at_respawn = 1f;
    float invulnTimer;
    int correctLayer;
    SpriteRenderer spriteRend;

    float invulnAnimTimer = 0;

    private void Start()
    {
        correctLayer = gameObject.layer;
        invulnTimer = invuln_at_respawn;
        spriteRend = GetComponent<SpriteRenderer>();
        if (spriteRend == null)
        {
            spriteRend = transform.GetComponentInChildren<SpriteRenderer>();
            Debug.LogError("Object '" + gameObject.name + "' has no sprite renderer.");
        }
    }

    void OnTriggerEnter2D() // im getting triggered
    {
        health--;
        Debug.Log("Trigger");              
        //if (invulnTimer > 0) {
        invulnTimer = invulnPeriod;
        gameObject.layer = 10;
        //}
    }

    void Update()
    {        
        if (invulnTimer > 0) // What happens while im invulnerable
        {
            invulnTimer -= Time.deltaTime;  //Timer Counts down
            if (invulnTimer <= 0  )
            {
                gameObject.layer = correctLayer;    // go back to correct layer

                if (spriteRend != null)
                {
                    spriteRend.enabled = true;
                }
            }
            else
            {
                if (spriteRend != null)
                {
                    spriteRend.enabled = !spriteRend.enabled;
                }
            }
        }
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}

