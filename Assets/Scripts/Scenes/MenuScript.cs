using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject HowToPlayText;

    void Start()
    {
        HowToPlayText.SetActive(false);
    }

    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ScoreButton()
    {
        SceneManager.LoadScene(1);
    }

    public void TimeButton()
    {
        SceneManager.LoadScene(2);
    }

    public void HowToPlayButton()
    {
        if (!HowToPlayText.active)
            HowToPlayText.SetActive(true);
        else
            HowToPlayText.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
