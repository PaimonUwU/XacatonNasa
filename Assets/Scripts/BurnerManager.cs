using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerManager : MonoBehaviour
{
    private float timer;
    private int randomN;
    private bool selectEnemy;

    public GameObject[] bourner;
   
    void Start()
    {
        timer = 0;
        selectEnemy = false;
    }

   
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 6)
        {
            if (selectEnemy == false)
            {
               
                randomN = Random.Range(0, 7);
               
                if(randomN == 0)
                {
                    StartCoroutine(EnemyAppear0());
                }
                if(randomN == 1)
                {
                    StartCoroutine(EnemyAppear1());
                }
                if (randomN == 2)
                {
                    StartCoroutine(EnemyAppear2());
                }
                if (randomN == 3)
                {
                    StartCoroutine(EnemyAppear3());
                }
                if (randomN == 4)
                {
                    StartCoroutine(EnemyAppear4());
                }
                if (randomN == 5)
                {
                    StartCoroutine(EnemyAppear5());
                }
                if (randomN == 6)
                {
                    StartCoroutine(EnemyAppear6());
                }
                if (randomN == 7)
                {
                    StartCoroutine(EnemyAppear7());
                }
            }
        }
    }

    IEnumerator EnemyAppear0()
    {
        selectEnemy = true;
        bourner[0].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[0].SetActive(false);

        yield return new WaitForSeconds(3f);

        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear1()
    {
        selectEnemy = true;
        bourner[1].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[1].SetActive(false);

        yield return new WaitForSeconds(3f);
        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear2()
    {
        selectEnemy = true;
        bourner[2].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[2].SetActive(false);

        yield return new WaitForSeconds(3f);
        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear3()
    {
        selectEnemy = true;
        bourner[3].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[3].SetActive(false);

        yield return new WaitForSeconds(3f);
        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear4()
    {
        selectEnemy = true;
        bourner[4].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[4].SetActive(false);

        yield return new WaitForSeconds(3f);
        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear5()
    {
        selectEnemy = true;
        bourner[5].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[5].SetActive(false);

        yield return new WaitForSeconds(3f);
        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear6()
    {
        selectEnemy = true;
        bourner[6].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[6].SetActive(false);

        yield return new WaitForSeconds(3f);
        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear7()
    {
        selectEnemy = true;
        bourner[7].SetActive(true);

        yield return new WaitForSeconds(5f);

        bourner[7].SetActive(false);
        yield return new WaitForSeconds(3f);
        selectEnemy = false;
        timer = 0;
    }
}
