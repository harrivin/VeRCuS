using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDObject : MonoBehaviour, DragDropHandler
{
    private bool IsHeld;
    public GameObject sphere;
    private GameObject Reticle;
    public Button submitbutton;
    public int j;
    public static int position1;
    public string opponent;
    public Vector3 pos, pos1, pos2, pos3, pos4, pos5, pos6;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;

        if (Vector3.Distance(sphere.gameObject.transform.position,pos)==0 || Vector3.Distance(sphere.gameObject.transform.position, pos1) == 0 || Vector3.Distance(sphere.gameObject.transform.position, pos2) == 0 || Vector3.Distance(sphere.gameObject.transform.position, pos3) == 0 || Vector3.Distance(sphere.gameObject.transform.position, pos4) == 0 || Vector3.Distance(sphere.gameObject.transform.position, pos5) == 0 || Vector3.Distance(sphere.gameObject.transform.position, pos6) == 0)
        {
            Debug.Log("wohoo");
            score.scoreg = score.scoreg - 5;
        }
    }

        public void HandleGazeTriggerStart()
    
    {
       // if (Input.GetButton("Fire1"))
       // {
          //  Debug.Log("fire1");
            IsHeld = true;
            GetComponent<Renderer>().material.color = Color.blue;
        //}
    }
    public void HandleGazeTriggerEnd()
    {
        //if (Input.GetButton("Fire2"))
        //{
         //   Debug.Log("fire2");
            IsHeld = false;
            GetComponent<Renderer>().material.color = Color.yellow;
        //}
    }
    // Use this for initialization
    void Start()
    {
        pos = new Vector3(-35, 5, 29f);
        pos1 = new Vector3(-5, 5, 29f);
        pos2 = new Vector3(5, 5, 29f);
        pos3 = new Vector3(35, 5, 29f);
        pos4 = new Vector3(-20, 20, 29f);
        pos5 = new Vector3(20, 20, 29f);
        pos6 = new Vector3(0, 30, 29f);
        IsHeld = false;
        GetComponent<Renderer>().material.color = Color.yellow;
        Reticle = GameObject.Find("DDReticle");
        submitbutton.gameObject.SetActive(false);
        //StartCoroutine("positioncheck");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsHeld)
        {
            Ray ray = new Ray(Reticle.transform.position, Reticle.transform.forward);
            transform.position = ray.GetPoint(25);
            //Debug.Log("yoho");
            //Debug.Log(gameObject.transform.position);
            // StopAllCoroutines();
        }
        else
        {
            if (transform.position.y < 0.75)
            {
                transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            }
            else if ((transform.position.x > -16.5 && transform.position.x <= -8.5) && (transform.position.y > 0.75 && transform.position.y <= 7.75))
            {
                // StartCoroutine("node1");
                //Debug.Log("node1");
                transform.position = pos;
                //positioncheck.position1++;
                //Debug.Log(positioncheck.position1);
            }
            else if ((transform.position.x > -8.5) && (transform.position.x <= 0) && (transform.position.y > 0.75) && (transform.position.y <= 7.75))
            {
                //StartCoroutine("node2");
                //Debug.Log("node2");
                transform.position = pos1;
                //positioncheck.position1++;
                //Debug.Log(positioncheck.position1);
            }
            else if ((transform.position.x > 0) && (transform.position.x <= 8.5) && (transform.position.y > 0.75) && (transform.position.y <= 7.75))
            {
                // StartCoroutine("node3");
                //Debug.Log("node3");
                transform.position = pos2;
                //positioncheck.position1++;

                //Debug.Log(positioncheck.position1);
            }
            else if ((transform.position.x > 8.5 && transform.position.x <= 16.5) && (transform.position.y > 0.75 && transform.position.y <= 7.75))
            {
                //  StartCoroutine("node4");
                //Debug.Log("node4");
                transform.position = pos3;
                //positioncheck.position1++;
               // Debug.Log(positioncheck.position1);
            }
            else if ((transform.position.x > -16.5 && transform.position.x <= 0) && (transform.position.y > 7.75 && transform.position.y <= 11.75))
            {
                //  StartCoroutine("node5");
                //Debug.Log("node5");
                transform.position = pos4;
                //positioncheck.position1++;
                //Debug.Log(positioncheck.position1);
            }
            else if ((transform.position.x > 0 && transform.position.x <= 16.5) && (transform.position.y > 7.75 && transform.position.y <= 11.75))
            {
                //   StartCoroutine("node6");
                //Debug.Log("node6");
                transform.position = pos5;
                //positioncheck.position1++;
                //Debug.Log(positioncheck.position1);
            }
            else if ((transform.position.x > -16.5 && transform.position.x <= 16.5) && (transform.position.y > 11.75 && transform.position.y <= 15.75))
            {
                //   StartCoroutine("node7");
                //Debug.Log("node7");
                transform.position = pos6;
                //positioncheck.position1++;
                //Debug.Log(positioncheck.position1);
            }
        }
    }
    //IEnumerator node1()
    //{
    //    while (true)
    //    {
    //        transform.position = new Vector3(-30, 10, 25.5f);
    //    }
    //}
    //IEnumerator node2()
    //{
    //    while (true)
    //    {
    //        transform.position = new Vector3(-10, 10, 25.5f);
    //    }
    //}
    //IEnumerator node3()
    //{
    //    while (true)
    //    {
    //        transform.position = new Vector3(10, 10, 25.5f);
    //    }
    //}
    //IEnumerator node4()
    //{
    //    while (true)
    //    {
    //        transform.position = new Vector3(30, 10, 25.5f);
    //    }
    //}
    //IEnumerator node5()
    //{
    //    while (true)
    //    {
    //        transform.position = new Vector3(20, 20, 25.5f);
    //    }
    //}
    //IEnumerator node6()
    //{
    //    while (true)
    //    {
    //        transform.position = new Vector3(-20, 20, 25.5f);
    //    }
    //}
    //IEnumerator node7()
    //{
    //    while (true)
    //    {
    //        transform.position = new Vector3(0, 0, 25.5f);
    //    }
    //}
    //IEnumerator positioncheck()
    //{
    //    while (true)
    //    {
    //        if (Vector3.Distance(transform.position, pos) == 0f || Vector3.Distance(transform.position, pos1) == 0f || Vector3.Distance(transform.position, pos2) == 0f || Vector3.Distance(transform.position, pos3) == 0f || Vector3.Distance(transform.position, pos4) == 0f || Vector3.Distance(transform.position, pos5) == 0f || Vector3.Distance(transform.position, pos6) == 0f)
    //        {
    //            Debug.Log("working");
    //        }
    //        else
    //        {
    //            Debug.Log("not working");
    //            StopCoroutine("positioncheck");
    //        }
    //    }
    //}
}

