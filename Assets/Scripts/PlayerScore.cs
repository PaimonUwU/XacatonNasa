using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance;

    public GameObject demon;
    public float timer,bossBegin,bossEnd;
    public int km;
    public GameObject savePlayer;

    public Slider slider;
    //public TextMeshProUGUI textScore;

    public Volume vol;
    DepthOfField dof;
    public GameObject redScreen;
    public GameObject songLevel;
    public GameObject songBoss;
    public GameObject deactiveFog;
    public GameObject winText;
    

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        timer = 0;
        km = 0;

        slider.maxValue = PlayerScore.instance.bossEnd;
        
    }

    
    void Update()
    {
        //Debug.Log(timer);
        if (vol.profile.TryGet<DepthOfField>(out dof))
        {
            dof.focalLength.value = bossBegin-timer;
        }

        if(timer > bossBegin - 3)
        {
            redScreen.SetActive(true);
            songLevel.SetActive(false);
            songBoss.SetActive(true);
        }

        if (timer > bossBegin)
        {
            
            demon.SetActive(true);
        }

        if(timer > bossBegin + 6)
        {
            redScreen.SetActive(false);
        }

       if(timer > bossEnd)
        {
            //demon.SetActive(false);
            winText.SetActive(true);
            savePlayer.SetActive(false);
            //deactiveFog.SetActive(false);

            StartCoroutine(WinScene());
        }

       
        //textScore.text = "KM: " + km;

        if(PlayerMovement.instance.isAlive == true)
        {
            timer += Time.deltaTime;
            slider.value = timer;
        }
        else
        {
            timer = 0;
        }
    }

    IEnumerator WinScene()
    {
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene("MENU");
    }
}
