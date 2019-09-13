using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    public bool GamsIsPaused = false;
    public Canvas PauseMenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        PauseMenuUI.enabled = true;
        GamsIsPaused = false;
    }

    private void Awake()
    {
        GamsIsPaused = false;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamsIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.enabled = false;
        Time.timeScale = 1f;
        GamsIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.enabled = true;
        Time.timeScale = 0f;
        GamsIsPaused = true;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}