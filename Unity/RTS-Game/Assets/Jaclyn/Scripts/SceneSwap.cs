using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwap : MonoBehaviour
{
    //Variables
    public AudioSource click;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickAnywhere()
    {
        click.Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void StartButton()
    {
        click.Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Matthew 1");
    }

    public void BackStartButton()
    {
        click.Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("TitleMenu");
    }

    public void ExitButton()
    {
        click.Play();
        Application.Quit();
    }
}
