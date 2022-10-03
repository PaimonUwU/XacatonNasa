using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSounds : MonoBehaviour
{
    
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    public void ThowBomb()
    {
        SoundManager.instance.BananaAudio(4);
    }

    public void Explotion()
    {
        SoundManager.instance.BananaAudio(5);
    }
}
