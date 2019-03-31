using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string level1;
    public string level2;

    public void Startlevel1()
    {
        SceneManager.LoadScene(level1);
    }

    public void Startlevel2()
    {
        SceneManager.LoadScene(level2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
