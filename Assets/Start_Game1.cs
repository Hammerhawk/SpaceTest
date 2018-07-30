using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Start_Game1 : MonoBehaviour {


    private void OnMouseDown()
    {
        Debug.Log("CLICK");
        SceneManager.LoadScene("FirstScene");
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
