using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBurner : MonoBehaviour
{
    public GameObject laser;
   
    private float timer;

    private bool attacking;
    private bool shooting;

    void OnEnable()
    {
        timer = 0;

        shooting = false;
        attacking = false;
        laser.SetActive(false);
      
    }

    
    void Update()
    {
        timer += Time.deltaTime;
       
        if(timer > 2.4f)
        {
            if(shooting  == false)
            {
                StartCoroutine(SoundTrue());
            }
            
        }

        if (timer > 5)
        {
            if (attacking != true)
            {
                StartCoroutine(ShowLaser());
            }
        }
    }

    IEnumerator SoundTrue()
    {
        shooting = true;
        SoundManager.instance.BananaAudio(3);

        yield return new WaitForSeconds(6);

        shooting = false;
    }

    IEnumerator ShowLaser()
    {
       
        attacking = true;
        laser.SetActive(true);

        yield return new WaitForSeconds(5.8f);

        laser.SetActive(false);
        attacking = false;
        timer = 0;
    }
}
