using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour
{
    public AudioSource ps;
    public void QuitButton(int sceneIndex)
    {
        ps.Play();
        SceneManager.LoadScene(sceneIndex);
    }
}
