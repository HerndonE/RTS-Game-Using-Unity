using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public static bool paused;
    public GameObject Canvas;

    public void Start()
    {
        paused = false;
        Canvas = GameObject.Find("PauseMenu");
        Canvas.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            /*if (paused)
                Resume();
            else*/
                Pause();
        }
    }

    public void Pause()
    {
        paused = !paused;
        Canvas.SetActive(paused);

        if (paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    /*public void Pause()
    {
        paused = true;
        Canvas.SetActive(true);

        Time.timeScale = 0;
    }

    public void Resume() {
        paused = false;
        Canvas.SetActive(false);

        Time.timeScale = 1;
    }*/
}