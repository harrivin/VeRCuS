using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupsphere : MonoBehaviour {

    public int spherenumber;
    static public int collected;
    public int collected1=0;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    public void pickupspheree()
    {
        Debug.Log("enter function");
        if(Input.GetButton("Fire1"))
        {
            this.gameObject.SetActive(false);
            Debug.Log("clicking");

        }
        else
        {
            Debug.Log("not clicking");
            this.gameObject.SetActive(true);
        }
    }
}
