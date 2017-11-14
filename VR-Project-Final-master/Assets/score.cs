using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public static int scoreg;
    Text text;


	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        scoreg = 0;

	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Score : " + scoreg;
	}
}
