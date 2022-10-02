using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    public GameObject enemigo;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        enemigo.SetActive(true);
    }
}
