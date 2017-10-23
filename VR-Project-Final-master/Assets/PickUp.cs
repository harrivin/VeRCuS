using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public int pickupcount;
	// Use this for initialization
	void Start () {
        pickupcount = 0;	
	}

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            pickupcount++;
            Debug.Log(pickupcount);
            if (pickupcount > 6)
            {
                StartCoroutine(waitFiveSeconds());
                Debug.Log("ALL NODES COLLECTED");
            }
        }
    }
    IEnumerator waitFiveSeconds()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel("VR Scene1");
    }
}
