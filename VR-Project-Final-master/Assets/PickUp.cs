using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public int pickupcount;
    public GameObject sphere;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;

    // Use this for initialization
    void Start () {
        pickupcount = 0;
        sphere = GameObject.Find("PickUp/Sphere");
        sphere1 = GameObject.Find("PickUp/Sphere1");
        sphere2 = GameObject.Find("PickUp/Sphere2");
        sphere3 = GameObject.Find("PickUp/Sphere3");
        sphere4 = GameObject.Find("PickUp/Sphere4");
        sphere5 = GameObject.Find("PickUp/Sphere5");
        sphere6 = GameObject.Find("PickUp/Sphere6");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject==sphere)
        {
            sphere.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            Debug.Log("sphere");
        }
        else if (other.gameObject==sphere1)
        {
            sphere1.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            Debug.Log("sphere1");
        }
        else if (other.gameObject==sphere2)
        {
            sphere2.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            Debug.Log("sphere2");
        }
        else if (other.gameObject==sphere3)
        {
            sphere3.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            Debug.Log("sphere3");
        }
        else if (other.gameObject==sphere4)
        {
            sphere4.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            Debug.Log("sphere4");
        }
        else if (other.gameObject==sphere5)
        {
            sphere5.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            Debug.Log("sphere5");
        }
        else if (other.gameObject==sphere6)
        {
            sphere6.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            Debug.Log("sphere6");
        }
        if (pickupcount > 6)
        {
            StartCoroutine(waitFiveSeconds());
            Debug.Log("ALL NODES COLLECTED");
        }
    }
    IEnumerator waitFiveSeconds()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel("VR Scene1");
    }
}
