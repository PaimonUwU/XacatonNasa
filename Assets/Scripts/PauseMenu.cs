using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamesIsPaused = false;
    public GameObject pauseMenuUI;
   // private AudioSource [] sound;
    // Start is called before the first frame update
    void Start()
    {
        //sound = GameObject.Find("Player").GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamesIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamesIsPaused = false;
        
    }

    public void Restart()
    {
       
        Time.timeScale = 1f;
        SceneManager.LoadScene("GAME");

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamesIsPaused = true;
        //sound[2].Stop();
        
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MENU");
    }

    public void QuitGame()
    {
        Application.Quit();

    }



}
