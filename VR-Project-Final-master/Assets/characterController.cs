using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {
    Animator anim1;
    public float speed = 10.0f;
    public float roationSpeed = 100.0f;
    public GameObject sphere;

   // public GameObject player;


    // Use this for initialization
    void Start()
    {
        //player = GameObject.Find("FPSController/Player");

        anim1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
        if (Input.GetButton("Fire1"))
        {
            anim1.SetBool("isAttacking", true);
          
        }
        else
        {
            anim1.SetBool("isAttacking", false);
           
        }

        if (translation != 0)
        {
            anim1.SetBool("isWalking", true);
            anim1.SetBool("isIdle", false);
            
        }
        else
        {
            anim1.SetBool("isWalking", false);
            anim1.SetBool("isIdle", true);
          
        }
        if (anim1.GetBool("isAttacking") == true)
        {
            //Debug.Log("attacking");
            sphere.SetActive(true);
        }
        else
        {
            //Debug.Log("notattacking");
            sphere.SetActive(false);
        }
    }
}
