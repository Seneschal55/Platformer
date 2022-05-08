using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public GameObject scoreTextUI;
    public static int scoreCount;
    public int scoreToWin = 250;

    void Start()
    {
        scoreCount = 0;
    }

    
    void Update()
    {
        scoreTextUI.GetComponent<Text>().text = "SCORE: " + scoreCount;
        if (scoreCount == scoreToWin)
        {
            SceneManager.LoadScene(0);
        }
    }
}
