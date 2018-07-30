using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUV : MonoBehaviour {


    public float parralax = 2f;
    public float scroolspeed = 10;

    // Update is called once per frame
    void Update()
    {

        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.x = transform.position.x / transform.localScale.x / parralax;
        offset.y = transform.position.y / transform.localScale.y / parralax;
        //offset.y += Time.deltaTime / scroolspeed;

        mat.mainTextureOffset = offset;



    }
}
