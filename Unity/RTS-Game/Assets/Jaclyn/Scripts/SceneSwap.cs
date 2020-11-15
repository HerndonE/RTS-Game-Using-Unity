using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwap : MonoBehaviour
{
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
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void StartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
