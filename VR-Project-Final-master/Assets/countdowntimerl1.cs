using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdowntimerl1 : MonoBehaviour
{
    //public static int timer = 0;
    //public static int ctimer;
    public int timeLeft1;

    public Text countdownText;
   // public string LevelToLoad;

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
       // scoreg = 0;

        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    // Use this for initialization
    void Start()
    {
     //   timer++;
       // if(timer>1)
       // {
        //    timeLeft1 = ctimer;
       //     Debug.Log(ctimer);
        //    Debug.Log(timeLeft1);
            score.scoreg = score.scoreg - 350;
       // }
        StartCoroutine("LoseTimel");
        //StartCoroutine("Time");
    }
    //void OnLevelWasLoaded(int level)
    //{
    //    if (level == 1)
    //    {
    //        StartCoroutine("LoseTime");
    //    }
    //}

    //private void fixedupdate()
    //{
    //    if (score.scoreg > 0)
    //    {
    //        startcoroutine("time");
    //    }
    //    else if (score.scoreg <= 0)
    //    {
    //        stopcoroutine("time");
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft1);



        if (timeLeft1 <= 0)
        {
            StopCoroutine("LoseTimel");
            // StopCoroutine("Time");
            countdownText.text = "Times Up!";
            Application.LoadLevel("GO Scene");
        }
    }

    IEnumerator LoseTimel()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft1--;
            if (score.scoreg > 0)
            {
                score.scoreg--;
            }
            //if (PickUp.pickupcount > 6)
            //{
            //    score.scoreg += timeLeft1;
            //    StopCoroutine("LoseTime");

            //}

        }
    }
    void OnDisable()
    {
        //ctimer = timeLeft1;
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}