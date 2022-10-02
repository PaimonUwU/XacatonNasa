using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance;

    public GameObject demon;
    public float timer;
    public int km;
    public GameObject savePlayer;
    //public TextMeshProUGUI textScore;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        timer = 0;
        km = 0;
    }

    
    void Update()
    {
        Debug.Log(timer);

       if(timer > 120)
        {
            demon.SetActive(true);
        }

       if(timer > 150)
        {
            demon.SetActive(false);
            savePlayer.SetActive(false);
        }

       
        //textScore.text = "KM: " + km;

        if(PlayerMovement.instance.isAlive == true)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }
    }
}
