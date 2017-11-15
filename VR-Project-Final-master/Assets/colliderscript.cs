using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colliderscript : MonoBehaviour
{
    public string opponent1;
    public int k = 0;

    public Button submitbutton1;
    public GameObject[] cubes;

    // Use this for initialization
    void Start()
    {
        submitbutton1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (j == 1)
        //{
        //    submitbutton1.gameObject.SetActive(false);
        //}
        //else
        //{
        //    submitbutton1.gameObject.SetActive(true);
        //}

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent1) return;
        k++;
        // if (col.gameObject.name == "Sphere" || col.gameObject.name == "Sphere1" || col.gameObject.name == "Sphere2" || col.gameObject.name == "Sphere3" || col.gameObject.name == "Sphere4" || col.gameObject.name == "Sphere5" || col.gameObject.name == "Sphere6")

        Debug.Log(k);
        Debug.Log("wogoo");


        if (cubes[0].GetComponent<colliderscript>().k == 1 && cubes[1].GetComponent<colliderscript>().k == 1 && cubes[2].GetComponent<colliderscript>().k == 1 && cubes[3].GetComponent<colliderscript>().k == 1 && cubes[4].GetComponent<colliderscript>().k == 1 && cubes[5].GetComponent<colliderscript>().k == 1 && cubes[6].GetComponent<colliderscript>().k == 1)
        {

            submitbutton1.gameObject.SetActive(true);
        }
        else
        {
            submitbutton1.gameObject.SetActive(false);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != opponent1) return;
        k--;
        Debug.Log(k);
        if (cubes[0].GetComponent<colliderscript>().k == 1 && cubes[1].GetComponent<colliderscript>().k == 1 && cubes[2].GetComponent<colliderscript>().k == 1 && cubes[3].GetComponent<colliderscript>().k == 1 && cubes[4].GetComponent<colliderscript>().k == 1 && cubes[5].GetComponent<colliderscript>().k == 1 && cubes[6].GetComponent<colliderscript>().k == 1)
        {

            submitbutton1.gameObject.SetActive(true);
        }
        else
        {
            submitbutton1.gameObject.SetActive(false);

        }
    }
}