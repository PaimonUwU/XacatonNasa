using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance;

    public float timer;
    public int km;
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
