using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chase : MonoBehaviour {

    public Transform player;
    public Transform head;
    public GameObject sphere;
    public GameObject enemy1;
    public GameObject enemy2;
    public string opponent1;

    public string enemynumber;

    public Slider healthbar;

    public UnityEngine.AI.NavMeshAgent agent;
    public GameObject opponent;

    Animator anim;
    //bool pursuing = false;

    string state = "patrol";
    public GameObject[] waypoints;
    int currentWP = 0;
    public float rotspeed = 0.2f;
    public float speed = 1.5f;
    float accuracyWP = 5.0f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent1) return;

        healthbar.value -= 25;
        Debug.Log("Hit");
        Vector3 direction1 = player.position - this.transform.position;
        direction1.y = 0;
        //float angle = Vector3.Angle(direction1, head.up);
        //state = "pursuing";
        agent.SetDestination(opponent.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction1), rotspeed * Time.deltaTime);

        if (healthbar.value <= 0)
        {
            anim.SetBool("isDead", true);
        }
    }
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        state = "patrol";
        opponent = GameObject.Find("FPSController");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim.speed = 1.5f;
  
	}

    // Update is called once per frame
    void Update()
    {
        //if(healthbar.value == healthbar.value-25)
        //{
        //    Vector3 direction1 = player.position - this.transform.position;
        //    direction1.y = 0;
        //    float angle1 = Vector3.Angle(direction1, head.up);
        //}
        if (healthbar.value <= 0)
        {
            StartCoroutine(waitDeath());
            StopCoroutine(waitDeath());
            enemy1.transform.parent = null;
            enemy1.SetActive(true);
            enemy2.transform.parent = null;
            enemy2.SetActive(true);
            return;
            //this.gameObject.SetActive = false;

        }

        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
        float angle = Vector3.Angle(direction, head.up);

        if (state == "patrol" && waypoints.Length > 0)
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", true);
            if (Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuracyWP)
            {
                currentWP = Random.Range(0, waypoints.Length);
                //currentWP++;
                //if(currentWP >= waypoints.Length)
                //{
                //    currentWP = 0;
                //}
            }
            agent.SetDestination(waypoints[currentWP].transform.position);
            //direction = waypoints[currentWP].transform.position - transform.position;
            //this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotspeed * Time.deltaTime);
            //this.transform.Translate(0, 0, Time.deltaTime * speed);
        }

        if (Vector3.Distance(player.position, this.transform.position) < 10 && (angle < 30 || state == "pursuing"))
        {
            state = "pursuing";
            agent.SetDestination(opponent.transform.position);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), rotspeed * Time.deltaTime);

            //anim.SetBool("isIdle", false);
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, Time.deltaTime * speed);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
                sphere.SetActive(false);
            }
            else
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking", false);
                sphere.SetActive(true);
            }
        }
        else
        {
            //anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", true);
            anim.SetBool("isAttacking", false);
            state = "patrol";
            sphere.SetActive(false);

        }

    }
    IEnumerator waitDeath()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }
}
