using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUp : MonoBehaviour {
    public static int pickupcount;
    public Slider healthbar;
    public GameObject sphere;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject sphere5;
    public GameObject sphere6;
    public GameObject health;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject health4;
    public GameObject health5;
    public GameObject health6;


    public GameObject text1;
    //public GameObject text2;
    Text txt1;
    //Text txt2;
    public int collected;

    

    // Use this for initialization
    void Start () {
        pickupcount = 0;
        //health = GameObject.Find("health");
        //health1 = GameObject.Find("health1");
        //health2 = GameObject.Find("health2");
        //health3 = GameObject.Find("health3");
        //health4 = GameObject.Find("health4");
        //health5 = GameObject.Find("health5");
        //health6 = GameObject.Find("health6");

        sphere = GameObject.Find("PickUp/Sphere");
        sphere1 = GameObject.Find("PickUp/Sphere1");
        sphere2 = GameObject.Find("PickUp/Sphere2");
        sphere3 = GameObject.Find("PickUp/Sphere3");
        sphere4 = GameObject.Find("PickUp/Sphere4");
        sphere5 = GameObject.Find("PickUp/Sphere5");
        sphere6 = GameObject.Find("PickUp/Sphere6");
        text1 = GameObject.Find("FPSController/Canvas/Text1");
       

        //text2 = GameObject.Find("FPSController/Canvas/Text2");
        txt1 = text1.GetComponent<Text>();
        //txt2 = text2.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthbar.value>600)
        {
            healthbar.value = 600;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject==health)
        {
            Debug.Log("successs");
            healthbar.value += 150;
            health.SetActive(false);
        }
        else if (other.gameObject == health1)
        {
            Debug.Log("successs1");
            healthbar.value += 150;
            health1.SetActive(false);
        }
        else if (other.gameObject == health2)
        {
            Debug.Log("successs2");
            healthbar.value += 150;
            health2.SetActive(false);
        }
        else if (other.gameObject == health3)
        {
            Debug.Log("success3");
            healthbar.value += 300;
            health3.SetActive(false);
        }
        else if (other.gameObject == health4)
        {
            Debug.Log("success4");
            healthbar.value += 150;
            health4.SetActive(false);
        }
        else if (other.gameObject == health5)
        {
            Debug.Log("success5");
            healthbar.value += 150;
            health5.SetActive(false);
        }
        else if (other.gameObject == health6)
        {
            Debug.Log("success6");
            healthbar.value += 150;
            health6.SetActive(false);
        }
        if (other.gameObject==sphere)
        {
            sphere.SetActive(false);
            pickupsphere.collected = 0;
            pickupsphere pus = sphere.GetComponent<pickupsphere>();
            pus.collected1 = 1;
            txt1.text = "Kill 0 to get health";
            //txt2.text = "";
            pickupcount++;
            score.scoreg += 1000;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere1)
        {
            sphere1.SetActive(false);
            pickupsphere.collected = 1;
            pickupsphere pus1 = sphere1.GetComponent<pickupsphere>();
            pus1.collected1 = 1;
            txt1.text = "Kill 1 to get health";
            //txt2.text = "to get full health";
            pickupcount++;
            score.scoreg += 1000;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere1");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere2)
        {
            sphere2.SetActive(false);
            pickupsphere.collected = 2;
            pickupsphere pus2 = sphere2.GetComponent<pickupsphere>();
            pus2.collected1 = 1;
            txt1.text = "Kill 2 to get health";
            //txt2.text = "to get full health";
            pickupcount++;
            score.scoreg += 1000;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere2");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere3)
        {
            sphere3.SetActive(false);
            pickupsphere.collected = 3;
            pickupsphere pus3 = sphere3.GetComponent<pickupsphere>();
            pus3.collected1 = 1;
            txt1.text = "Kill 3 to get health";
            //txt2.text = "to get full health";
            pickupcount++;
            score.scoreg += 1000;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere3");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere4)
        {
            sphere4.SetActive(false);
            pickupsphere.collected = 4;
            pickupsphere pus4 = sphere4.GetComponent<pickupsphere>();
            pus4.collected1 = 1;
            txt1.text = "Kill 4 to get health";
            //txt2.text = "to get full health";
            pickupcount++;
            score.scoreg += 1000;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere4");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere5)
        {
            sphere5.SetActive(false);
            pickupsphere.collected = 5;
            pickupsphere pus5 = sphere5.GetComponent<pickupsphere>();
            pus5.collected1 = 1;
            txt1.text = "Kill 5 to get health";
            //txt2.text = "to get full health";
            pickupcount++;
            score.scoreg += 1000;
            StartCoroutine(waitTextSeconds());
            Debug.Log(pickupcount);
            Debug.Log("sphere5");
            StopCoroutine(waitTextSeconds());
        }
        else if (other.gameObject==sphere6)
        {
            sphere6.SetActive(false);
            pickupsphere.collected = 6;
            pickupsphere pus6 = sphere6.GetComponent<pickupsphere>();
            pus6.collected1 = 1;
            txt1.text = "Kill 6 to get health";
            //txt2.text = "to get full health";
            pickupcount++;
            score.scoreg += 1000;
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
        Application.LoadLevel("VR Scene 1");
    }
    IEnumerator waitTextSeconds()
    {
        yield return new WaitForSeconds(5);
        txt1.text = "";
        //txt2.text = "";
    }
}
