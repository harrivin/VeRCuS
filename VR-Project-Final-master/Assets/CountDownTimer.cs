using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public int timeLeft = 0;

    public Text countdownText;
    public string LevelToLoad;

    // Use this for initialization
    void Start()
    {

        StartCoroutine("LoseTime");
        //StartCoroutine("Time");
    }
    //void OnLevelWasLoaded(int level)
    //{
    //    if (level == 0)
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

  
}