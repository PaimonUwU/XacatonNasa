using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip[] audios;
    private AudioSource manager;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

        manager = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        
    }

    public void BananaAudio(int indice)
    {
        manager.PlayOneShot(audios[indice]);
    }
}
