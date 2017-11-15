using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1movelevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    public void movelevel()
    {
       // Debug.Log("enter movelevel function");
        if (Input.GetButton("Fire3"))
        {
            Application.LoadLevel("VR Scene 2");
           

        }
        else
        {
         //   Debug.Log("not clicking");
            //this.gameObject.SetActive(true);
        }
    }
}
