using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Generator : MonoBehaviour
{
    public static Generator instance;

    public int numberRandom;
    private bool itRespawned;
    public float cooldownRespawn;
    public Transform[] resPoints;
    public GameObject prefAsteroid;

   
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        numberRandom = Random.Range(0, 6);
        itRespawned = false;
    }

   
    void Update()
    {
       if(itRespawned != true)
       {
            Debug.Log(numberRandom);
            StartCoroutine(CooldownRespawn());

            if(numberRandom == 0)
            {
                Instantiate(prefAsteroid, resPoints[0].position, Quaternion.identity);
            }

            if(numberRandom == 1)
            {
                Instantiate(prefAsteroid, resPoints[1].position, Quaternion.identity);
            }

            if(numberRandom == 2)
            {
                Instantiate(prefAsteroid, resPoints[2].position, Quaternion.identity);
            }

            if (numberRandom == 3)
            {
                Instantiate(prefAsteroid, resPoints[3].position, Quaternion.identity);
            }

            if (numberRandom == 4)
            {
                Instantiate(prefAsteroid, resPoints[4].position, Quaternion.identity);
            }

            if (numberRandom == 5)
            {
                Instantiate(prefAsteroid, resPoints[5].position, Quaternion.identity);
            }

            if (numberRandom == 6)
            {
                Instantiate(prefAsteroid, resPoints[6].position, Quaternion.identity);
            }
        }
    }

    IEnumerator CooldownRespawn()
    {
        numberRandom = Random.Range(0, 6);
        itRespawned = true;

        yield return new WaitForSeconds(cooldownRespawn);

        itRespawned = false;
    }
}
