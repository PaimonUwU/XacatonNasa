using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    private int life;
    private bool inmunity;
    private SpriteRenderer sprite;

    void Start()
    {
        life = 6;
        inmunity = false;

        sprite = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            if (inmunity == false)
            {
                if(life > 0)
                {
                    StartCoroutine(CooldownLife());
                }
                else
                {
                    PlayerMovement.instance.isAlive = false;
                    Destroy(gameObject);
                }
                
            }
        }
    }

    IEnumerator CooldownLife()
    {
        inmunity = true;
        life--;
        sprite.color = new Color(255, 0, 0);

        yield return new WaitForSeconds(0.5f);

        inmunity = false;
        sprite.color = new Color(0, 256, 6);
    }

   
}
