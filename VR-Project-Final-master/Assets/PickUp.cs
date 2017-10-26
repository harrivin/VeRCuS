using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUp : MonoBehaviour {
    public int pickupcount;
    public GameObject sphere;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject text1;
    public GameObject text2;
    Text txt1;
    Text txt2;

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
        text1 = GameObject.Find("FPSController/Canvas/Text1");
        text2 = GameObject.Find("FPSController/Canvas/Text2");
        txt1 = text1.GetComponent<Text>();
        txt2 = text2.GetComponent<Text>();
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
            txt1.text = "Kill 0";
            txt2.text = "to get full health";
            pickupcount++;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere1)
        {
            sphere1.SetActive(false);
            txt1.text = "Kill 1";
            txt2.text = "to get full health";
            pickupcount++;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere1");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere2)
        {
            sphere2.SetActive(false);
            txt1.text = "Kill 2";
            txt2.text = "to get full health";
            pickupcount++;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere2");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere3)
        {
            sphere3.SetActive(false);
            txt1.text = "Kill 3";
            txt2.text = "to get full health";
            pickupcount++;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere3");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere4)
        {
            sphere4.SetActive(false);
            txt1.text = "Kill 4";
            txt2.text = "to get full health";
            pickupcount++;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere4");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere5)
        {
            sphere5.SetActive(false);
            txt1.text = "Kill 5";
            txt2.text = "to get full health";
            pickupcount++;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere5");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere6)
        {
            sphere6.SetActive(false);
            txt1.text = "Kill 6";
            txt2.text = "to get full health";
            pickupcount++;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere6");
            StopCoroutine(waitTextSeconds());
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
    IEnumerator waitTextSeconds()
    {
        yield return new WaitForSeconds(5);
        txt1.text = "";
        txt2.text = "";
    }
}
