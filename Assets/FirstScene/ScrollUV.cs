﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour {

    public float scroolspeed = 10f;

    // Update is called once per frame
    void Update() {

        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.y += Time.deltaTime / scroolspeed;

        mat.mainTextureOffset = offset;

        

	}
}
