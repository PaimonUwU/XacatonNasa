using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public AudioSource mySounds;
    public AudioClip myHoverClip;
    public AudioClip myClickSound;   



    public void HoverSound()
    {
        mySounds.PlayOneShot(myHoverClip);
    }

    public void ClickSound()
    {
        mySounds.PlayOneShot(myClickSound);
    }

}
