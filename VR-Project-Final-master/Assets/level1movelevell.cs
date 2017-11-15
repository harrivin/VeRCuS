using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1movelevell : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void movelevel1()
    {
        //Debug.Log("enter movelevel function");
        if (Input.GetButton("Fire4"))
        {
            Application.LoadLevel("VR Scene 1");


        }
        else
        {
           // Debug.Log("not clicking");
            //this.gameObject.SetActive(true);
        }
    }
}

