using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class level1movelevel : MonoBehaviour {
    //public GameObject[] cubes;
    //public GameObject[] spheres;
    //public Button yourButton;

    // Use this for initialization
    void Start () {
        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
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
            //button();
            Application.LoadLevel("VR Scene 2");


        }
        else
        {
            //   Debug.Log("not clicking");
            //this.gameObject.SetActive(true);
        }
    }
    //public void button()
    //{

    //}
   

 

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}

