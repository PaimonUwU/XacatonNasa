using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance;

    private float timer;
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
        timer += Time.deltaTime;
        //textScore.text = "KM: " + km;

        if(timer > 3 && PlayerMovement.instance.isAlive != false)
        {
            km++;
            timer = 0;
        }
    }
}
