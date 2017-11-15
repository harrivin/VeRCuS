using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score1 : MonoBehaviour
{

    public int scores1 = 0;
    Text text;

    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        scores1 = scores1 + 150;
        score.scoreg = score.scoreg + scores1;

        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        score.scoreg = scores1 + score.scoreg;


    }
    //void OnLevelWasLoaded(int level)
    //{
    //    if (level == 1)
    //        scores1 = scores1 + 150;
    //    Debug.Log(scores1);
    //    //     else if (level == 1)
    //    //        scoreg = scoreg + score1;
    //}
    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + score.scoreg;
    }
    // called when the game is terminated
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}




  

  

