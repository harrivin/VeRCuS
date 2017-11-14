using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detecthit : MonoBehaviour {

    public Transform player;
    public Transform head;
    public Slider healthbar;
    Animator anim;
    public string opponent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;

        healthbar.value -= 25;
        Debug.Log("Hit");
           //Vector3 direction1 = player.position - this.transform.position;
           // direction1.y = 0;
            //float angle1 = Vector3.Angle(direction1, head.up);

        if (healthbar.value <= 0)
        {
            anim.SetBool("isDead", true);
        }
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
  
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
