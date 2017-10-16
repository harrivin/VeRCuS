using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Transform target;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var euler = target.rotation.eulerAngles;   //get target's rotation
        var rot = Quaternion.Euler(0, euler.y, 0); //transpose values
        transform.rotation = Quaternion.Euler(0, euler.y, 0);
    }
}
