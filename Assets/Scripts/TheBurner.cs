using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBurner : MonoBehaviour
{
    public GameObject laser;
   
    private float timer;

    private bool attacking;

    void OnEnable()
    {
        timer = 0;

        attacking = false;
        laser.SetActive(false);
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 3)
        {
            if (attacking != true)
            {
                StartCoroutine(ShowLaser());
            }
        }
    }

    IEnumerator ShowLaser()
    {
       
        attacking = true;
        laser.SetActive(true);

        yield return new WaitForSeconds(2.8f);

        laser.SetActive(false);
        attacking = false;
        timer = 0;
    }
}
