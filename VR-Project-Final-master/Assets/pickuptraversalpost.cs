using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickuptraversalpost : MonoBehaviour {
    public static int pickupcount1;
    public GameObject[] sphere;
    public GameObject[] cube;
    public int collected, collected1, collected2, collected3, collected4, collected5, collected6;
    public int o1, o2, o3, o4, o5, o6, o7;

    // Use this for initialization
    void Start () {
        StartCoroutine("tada");
        pickupcount1 = 0;
        sphere[0] = GameObject.Find("PickUp/Sphere");
        sphere[1] = GameObject.Find("PickUp/Sphere1");
        sphere[2] = GameObject.Find("PickUp/Sphere2");
        sphere[3] = GameObject.Find("PickUp/Sphere3");
        sphere[4] = GameObject.Find("PickUp/Sphere4");
        sphere[5] = GameObject.Find("PickUp/Sphere5");
        sphere[6] = GameObject.Find("PickUp/Sphere6");
        cube[0]= GameObject.Find("PickUp/Sphere/Cube");
        cube[1] = GameObject.Find("PickUp/Sphere1/Cube");
        cube[2] = GameObject.Find("PickUp/Sphere2/Cube");
        cube[3] = GameObject.Find("PickUp/Sphere3/Cube");
        cube[4] = GameObject.Find("PickUp/Sphere4/Cube");
        cube[5] = GameObject.Find("PickUp/Sphere5/Cube");
        cube[6] = GameObject.Find("PickUp/Sphere6/Cube");
        collected = sphere[0].GetComponent<traversal>().collected;
        collected1 = sphere[1].GetComponent<traversal>().collected;
        collected2 = sphere[2].GetComponent<traversal>().collected;
        collected3 = sphere[3].GetComponent<traversal>().collected;
        collected4 = sphere[4].GetComponent<traversal>().collected;
        collected5 = sphere[5].GetComponent<traversal>().collected;
        collected6 = sphere[6].GetComponent<traversal>().collected;
        o1 = sphere[0].GetComponent<traversal>().order;
        o2 = sphere[1].GetComponent<traversal>().order;
        o3 = sphere[2].GetComponent<traversal>().order;
        o4 = sphere[3].GetComponent<traversal>().order;
        o5 = sphere[4].GetComponent<traversal>().order;
        o6 = sphere[5].GetComponent<traversal>().order;
        o7 = sphere[6].GetComponent<traversal>().order;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == sphere[0])
        {
            cube[0].transform.parent = null;
            cube[0].SetActive(true);

            if (pickupcount1 == o1)
            {
                cube[0].gameObject.GetComponent<Renderer>().material.color = Color.green;
                score.scoreg = score.scoreg + 50;
            }
            else
            {
                cube[0].gameObject.GetComponent<Renderer>().material.color = Color.red;
                score.scoreg = score.scoreg - 50;
            }
            sphere[0].SetActive(false);
            pickupcount1++;
            collected = 1;
        }
        else if (other.gameObject == sphere[1])
        {
            cube[1].transform.parent = null;
            cube[1].SetActive(true);

            if (pickupcount1 == o2)
            {
                cube[1].gameObject.GetComponent<Renderer>().material.color = Color.green;
                score.scoreg = score.scoreg + 50;
            }
            else
            {
                cube[1].gameObject.GetComponent<Renderer>().material.color = Color.red;
                score.scoreg = score.scoreg - 50;
            }
            sphere[1].SetActive(false);
            pickupcount1++;
            collected1 = 1;
        }
        else if (other.gameObject == sphere[2])

        {
            cube[2].transform.parent = null;
            cube[2].SetActive(true);

            if (pickupcount1 == o3)
            {
                cube[2].gameObject.GetComponent<Renderer>().material.color = Color.green;
                score.scoreg = score.scoreg + 50;
            }
            else
            {
                cube[2].gameObject.GetComponent<Renderer>().material.color = Color.red;
                score.scoreg = score.scoreg - 50;
            }
            sphere[2].SetActive(false);
            pickupcount1++;
            collected2 = 1;
        }
        else if (other.gameObject == sphere[3])

        {
            cube[3].transform.parent = null;
            cube[3].SetActive(true);

            if (pickupcount1 == o4)
            {
                cube[3].gameObject.GetComponent<Renderer>().material.color = Color.green;
                score.scoreg = score.scoreg + 50;
            }
            else
            {
                cube[3].gameObject.GetComponent<Renderer>().material.color = Color.red;
                score.scoreg = score.scoreg - 50;
            }
            sphere[3].SetActive(false);
            pickupcount1++;
            collected3 = 1;
        }
        else if (other.gameObject == sphere[4])

        {
            cube[4].transform.parent = null;
            cube[4].SetActive(true);

            if (pickupcount1 == o5)
            {
                cube[4].gameObject.GetComponent<Renderer>().material.color = Color.green;
                score.scoreg = score.scoreg + 50;
            }
            else
            {
                cube[4].gameObject.GetComponent<Renderer>().material.color = Color.red;
                score.scoreg = score.scoreg - 50;
            }
            sphere[4].SetActive(false);
            pickupcount1++;
            collected4 = 1;
        }
        else if (other.gameObject == sphere[5])

        {
            cube[5].transform.parent = null;
            cube[5].SetActive(true);

            if (pickupcount1 == o6)
            {
                cube[5].gameObject.GetComponent<Renderer>().material.color = Color.green;
                score.scoreg = score.scoreg + 50;
            }
            else
            {
                cube[5].gameObject.GetComponent<Renderer>().material.color = Color.red;
                score.scoreg = score.scoreg - 50;
            }
            sphere[5].SetActive(false);
            pickupcount1++;
            collected5 = 1;

        }
        else if (other.gameObject == sphere[6])

        {
            cube[6].transform.parent = null;
            cube[6].SetActive(true);

            if (pickupcount1 == o7)
            {
                cube[6].gameObject.GetComponent<Renderer>().material.color = Color.green;
                score.scoreg = score.scoreg + 50;
            }
            else
            {
                cube[6].gameObject.GetComponent<Renderer>().material.color = Color.red;
                score.scoreg = score.scoreg - 50;
            }
            sphere[6].SetActive(false);
            pickupcount1++;
            collected6 = 1;
            Debug.Log(pickupcount1);
        }

        //if (pickupcount1==7)
        //{
        //    StartCoroutine("tada");
        //    cube[0].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
        //    cube[1].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
        //    cube[2].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
        //    cube[3].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
        //    cube[4].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
        //    cube[5].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
        //    cube[6].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
        //}

    }

        // Update is called once per frame
        void Update () {
   if(pickupcount1==7)
        {
            Application.LoadLevel("GO Scene");
        }
       
    }
    IEnumerable tada()
    {
        while (true)
        {
            if (pickupcount1 == 7)
            {
                
                cube[0].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                cube[1].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                cube[2].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                cube[3].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                cube[4].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                cube[5].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                cube[6].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
                StopCoroutine("tada");
            }
            yield return new WaitForSeconds(5);
            //Application.LoadLevel("VR Scene 3");
        }
    }
}
