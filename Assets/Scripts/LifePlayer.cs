using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    public static LifePlayer instance;

    private int life;
    private bool inmunity;
    public bool shakeCam;
    private SpriteRenderer sprite;
    private int ranSound;
    private bool cooldownSound;
    private Animator aniBanana;
  
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        life = 6;
        inmunity = false;
        cooldownSound = false;

        sprite = GetComponent<SpriteRenderer>();
        aniBanana = GetComponent<Animator>();
        ranSound = 0;
    }

  
    void Update()
    {
       
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            if (inmunity == false)
            {
               
                StartCoroutine(CameraShakes.instance.ShakeCam());

                if(life > 0)
                {
                    ranSound++;

                    if (ranSound == 1)
                    {
                        SoundManager.instance.BananaAudio(1);
                    }

                    if(ranSound == 2)
                    {
                        SoundManager.instance.BananaAudio(2);
                        ranSound = 0;
                    }
                   

                    StartCoroutine(CooldownLife());
                }
                else
                {
                   
                    PlayerMovement.instance.isAlive = false;

                    if(cooldownSound == false)
                    {
                        StartCoroutine(CooldownSound());
                        cooldownSound = true;
                        SoundManager.instance.BananaAudio(0);
                    }
                    //Destroy(gameObject);
                }

                
            }
        }
    }

    IEnumerator CooldownSound()
    {
        aniBanana.SetBool("Dead", true);
        SoundManager.instance.BananaAudio(1);

        yield return new WaitForSeconds(6);

        cooldownSound = false;
        aniBanana.SetBool("Dead", false);
    }

    IEnumerator CooldownLife()
    {
       

        shakeCam = true;
        inmunity = true;
        life--;
        sprite.color = new Color(255, 0, 0);

        yield return new WaitForSeconds(0.5f);

        inmunity = false;
        sprite.color = new Color(255, 255, 255);
        shakeCam = true;
    }

   
}
