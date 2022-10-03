using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class LifePlatanoCanvas : MonoBehaviour
{
    private Image image;
    
    void Start()
    {
        image = GetComponent<Image>();
    }

   
    void Update()
    {
        if(LifePlayer.instance.life == 8)
        {
            image.fillAmount = 1;
        }

        if (LifePlayer.instance.life == 7)
        {
            image.fillAmount = 0.875f; ;
        }

        if (LifePlayer.instance.life == 6)
        {
            image.fillAmount = 0.75f; ;
        }

        if (LifePlayer.instance.life == 5)
        {
            image.fillAmount = 0.625f; ;
        }

        if (LifePlayer.instance.life == 4)
        {
            image.fillAmount = 0.5f; ;
        }

        if (LifePlayer.instance.life == 3)
        {
            image.fillAmount = 0.375f; ;
        }
        if (LifePlayer.instance.life == 2)
        {
            image.fillAmount = 0.25f; ;
        }

        if (LifePlayer.instance.life == 1)
        {
            image.fillAmount = 0.125f; ;
        }

        if (LifePlayer.instance.life == 0)
        {
            image.fillAmount = 0f; ;
        }
    }
}
