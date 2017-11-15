using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score2 : MonoBehaviour
{
    public static int scoreg;
    public int scorel2 = 0;
    Text text;

    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //scoreg = 0;

        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();


    }
    //void OnLevelWasLoaded(int level)
    //{
    //    if (level == 0)
    //        scoreg = 0;
    //    //     else if (level == 1)
    //    //        scoreg = scoreg + score1;
    //}

    //// Update is called once per frame
    void Update()
    {
        text.text = "Score : " + score.scoreg;
    }
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
