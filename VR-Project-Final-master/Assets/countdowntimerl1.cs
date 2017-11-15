using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdowntimerl1 : MonoBehaviour
{
    public static int timer;
    public static int ctimer;
    public int timeLeft = 0;

    public Text countdownText;
    public string LevelToLoad;

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
       // scoreg = 0;

        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    // Use this for initialization
    void Start()
    {
        timer++;
        Debug.Log(timer);
        if(timer>1)
        {
            timeLeft = ctimer;
            Debug.Log(ctimer);
            Debug.Log(timeLeft);
            score.scoreg = score.scoreg - 350;
        }
        StartCoroutine("LoseTime");
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
        countdownText.text = ("Time Left = " + timeLeft);



        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            // StopCoroutine("Time");
            countdownText.text = "Times Up!";
            Application.LoadLevel("GO Scene");
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (score.scoreg > 0)
            {
                score.scoreg--;
            }
            if (PickUp.pickupcount > 6)
            {
                score.scoreg += timeLeft;
                StopCoroutine("LoseTime");

            }

        }
    }
    void OnDisable()
    {
        ctimer = timeLeft;
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}