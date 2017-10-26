using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text2 : MonoBehaviour {
    public float time = 5; //Seconds to read the text
    Text txt;
 

    IEnumerator Start()
    {
        txt = gameObject.GetComponent<Text>();
        yield return new WaitForSeconds(time);
        txt.text = "";
    }

  
	
	// Update is called once per frame
	void Update ()
    {
    
    }
}
