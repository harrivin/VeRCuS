using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }
    public void moveboxup()
    {
        transform.position += new Vector3(0f, 1f, 0f);
    }
}
