using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonLeave : MonoBehaviour
{
    private Animator aniEnemy;

    void Start()
    {
        aniEnemy = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(PlayerScore.instance.timer > PlayerScore.instance.bossEnd - 5)
        {
            aniEnemy.SetBool("Leave", true);
        }
    }
}
