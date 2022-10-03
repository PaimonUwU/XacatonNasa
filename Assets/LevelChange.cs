using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeScena());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeScena()
    {
        yield return new WaitForSeconds(5.6f);

        SceneManager.LoadScene("GAME");
    }
}
