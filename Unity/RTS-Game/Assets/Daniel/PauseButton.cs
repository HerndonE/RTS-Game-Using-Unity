using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool paused;

    private void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            paused = !paused;
        }

        if (paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void Pause()
    {
        paused = !paused;

        if (paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
}
