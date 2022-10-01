using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerAdmi : MonoBehaviour
{
    public GameObject Panel;
    public void ChangeScene(string SceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneName);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ControlPanel()
    {
        Panel.SetActive(true);
    }

    public void ControlPanelExit()
    {
        Panel.SetActive(false);
    }


    public void ExitScene(string SceneName)
    {
        Application.Quit();
    }

   
} 