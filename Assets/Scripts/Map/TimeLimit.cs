using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
    public float startTime;
    public GameObject TimeTextUI;
    public float endTime;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        endTime = 60f;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time - startTime;
        if (currentTime >= endTime)
        {
            TimeTextUI.GetComponent<Text>().text = "TIME'S UP! YOU LOSE!";
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            TimeTextUI.GetComponent<Text>().text = "TIME: " + (currentTime);
        }

    }
}
