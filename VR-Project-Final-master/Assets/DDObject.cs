using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDObject : MonoBehaviour, DragDropHandler
{
    private bool IsHeld;
    private GameObject Reticle;
    public void HandleGazeTriggerStart()
    {
        IsHeld = true;
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void HandleGazeTriggerEnd()
    {
        IsHeld = false;
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    // Use this for initialization
    void Start()
    {
        IsHeld = false;
        GetComponent<Renderer>().material.color = Color.yellow;
        Reticle = GameObject.Find("DDReticle");
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHeld)
        {
            Ray ray = new Ray(Reticle.transform.position, Reticle.transform.forward);
            transform.position = ray.GetPoint(25);
            //Debug.Log("yoho");
            Debug.Log(gameObject.transform.position);
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
                Debug.Log("node1");
                transform.position = new Vector3(-35, 5, 20.5f);
            }
            else if ((transform.position.x > -8.5) && (transform.position.x <= 0) && (transform.position.y > 0.75) && (transform.position.y <= 7.75))
            {
                //StartCoroutine("node2");
                Debug.Log("node2");
                transform.position = new Vector3(-5, 5, 20.5f);
            }
            else if ((transform.position.x > 0) && (transform.position.x <= 8.5) && (transform.position.y > 0.75) && (transform.position.y <= 7.75))
            {
                // StartCoroutine("node3");
                Debug.Log("node3");
                transform.position = new Vector3(5, 5, 20.5f);
            }
            else if ((transform.position.x > 8.5 && transform.position.x <= 16.5) && (transform.position.y > 0.75 && transform.position.y <= 7.75))
            {
                //  StartCoroutine("node4");
                Debug.Log("node4");
                transform.position = new Vector3(35, 5, 20.5f);
            }
            else if ((transform.position.x > -16.5 && transform.position.x <= 0) && (transform.position.y > 7.75 && transform.position.y <= 11.75))
            {
                //  StartCoroutine("node5");
                Debug.Log("node5");
                transform.position = new Vector3(-20, 20, 20.5f);
            }
            else if ((transform.position.x > 0 && transform.position.x <= 16.5) && (transform.position.y > 7.75 && transform.position.y <= 11.75))
            {
                //   StartCoroutine("node6");
                Debug.Log("node6");
                transform.position = new Vector3(20, 20, 20.5f);
            }
            else if ((transform.position.x > -16.5 && transform.position.x <= 16.5) && (transform.position.y > 11.75 && transform.position.y <= 15.75))
            {
                //   StartCoroutine("node7");
                Debug.Log("node7");
                transform.position = new Vector3(0, 30, 20.5f);
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
}

 