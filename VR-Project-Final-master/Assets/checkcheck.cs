using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class checkcheck : MonoBehaviour {
    public GameObject[] cubes;
    public GameObject[] spheres;
    public Button yourButton;
    // Use this for initialization
    void Start () {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void TaskOnClick()
    {
        if (Vector3.Distance(cubes[0].gameObject.transform.position, spheres[3].gameObject.transform.position) < 2)
        { Debug.Log("success");
            cubes[0].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[0].gameObject.GetComponent<Renderer>().material.color = Color.green;
            score.scoreg += 50;
        }
        else
        {
            Debug.Log("failure");
            cubes[0].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[0].gameObject.GetComponent<Renderer>().material.color = Color.red;
            score.scoreg -= 50;
        }

        if (Vector3.Distance(cubes[1].gameObject.transform.position, spheres[5].gameObject.transform.position) < 2)
        { Debug.Log("success1");
            cubes[1].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[1].gameObject.GetComponent<Renderer>().material.color=Color.green;
            score.scoreg += 50; }
        else
        {
            Debug.Log("failure1");
            cubes[1].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[1].gameObject.GetComponent<Renderer>().material.color = Color.red;
            score.scoreg -= 50;
        }


        if (Vector3.Distance(cubes[2].gameObject.transform.position, spheres[1].gameObject.transform.position) < 2)
        { Debug.Log("success2");
            cubes[2].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[2].gameObject.GetComponent<Renderer>().material.color = Color.green;
            score.scoreg += 50; }
        else
        {
            Debug.Log("failure2");
            cubes[2].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[2].gameObject.GetComponent<Renderer>().material.color = Color.red;
            score.scoreg -= 50;
        }

        if (Vector3.Distance(cubes[3].gameObject.transform.position, spheres[0].gameObject.transform.position) < 2)
        { Debug.Log("success3");
            cubes[3].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[3].gameObject.GetComponent<Renderer>().material.color = Color.green;
            score.scoreg += 50; }
        else
        {
            Debug.Log("failure3");
            cubes[3].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[3].gameObject.GetComponent<Renderer>().material.color = Color.red;
            score.scoreg -= 50;
        }

        if (Vector3.Distance(cubes[4].gameObject.transform.position, spheres[2].gameObject.transform.position) < 2)
        { Debug.Log("success4");
            cubes[4].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[4].gameObject.GetComponent<Renderer>().material.color = Color.green;
            score.scoreg += 50; }
        else
        {
            Debug.Log("failure4");
            cubes[4].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[4].gameObject.GetComponent<Renderer>().material.color = Color.red;
            score.scoreg -= 50;
        }

        if (Vector3.Distance(cubes[5].gameObject.transform.position, spheres[4].gameObject.transform.position) < 2)
        { Debug.Log("success5");
            cubes[5].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[5].gameObject.GetComponent<Renderer>().material.color = Color.green;
            score.scoreg += 50; }
        else
        {
            Debug.Log("failure5");
            cubes[5].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[5].gameObject.GetComponent<Renderer>().material.color = Color.red;
            score.scoreg -= 50;
        }

        if (Vector3.Distance(cubes[6].gameObject.transform.position, spheres[6].gameObject.transform.position) < 2)
        {
            Debug.Log("success6");
            cubes[6].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[6].gameObject.GetComponent<Renderer>().material.color = Color.green;
            score.scoreg += 50;
        }
        else
        {
            Debug.Log("failure6");
            cubes[6].gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Standard");
            cubes[6].gameObject.GetComponent<Renderer>().material.color = Color.red;
            score.scoreg -= 50;
        }


        //Debug.Log("You have clicked the button!");
        StartCoroutine("loadlevel");
        
    }
    IEnumerator loadlevel()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Application.LoadLevel("VR Scene 2");
            StopCoroutine("loadlevel");
        }
    }
}
