using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 9f;

    private void Start()
    {
        //LoadNextScene();
        //StartCoroutine(ChangeScene());
    }

    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Return))
        {
            LoadNextScene();
        }
        */
     
        
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

     
    }

    IEnumerator LoadLevel(int levelindex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelindex);

        yield return new WaitForSeconds(4);
        //StartCoroutine(ChangeScene());
         SceneManager.LoadScene("GAME");
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(6.7f);

        SceneManager.LoadScene("GAME");
    }

    public void SceneLoader()
    {
        SceneManager.LoadScene("GAME");
    }
}
