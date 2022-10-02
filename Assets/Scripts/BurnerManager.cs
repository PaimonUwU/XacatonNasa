using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerManager : MonoBehaviour
{
    private float timer;
    private float timer2;
    private int randomN;
    private bool selectEnemy;
    private bool selectEnemy2;
    private float limitTimer;
    private float limitTimer2;

    public GameObject[] bourner;
   
    void Start()
    {
        timer = 0;
        timer2 = 0;
        selectEnemy = false;
        selectEnemy2 = false;
        limitTimer = 6;
        limitTimer2 = 3;
    }

   
    void Update()
    {
        //Debug.Log(limitTimer);
        //Limita el timer para que no se reduzca mas de el limite
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;

        if(limitTimer <= 1.7f)
        {
            limitTimer = 1.7f;
        }

        if(PlayerScore.instance.timer > 20f)
        {
            if (timer > limitTimer)
            {
                if (selectEnemy == false)
                {
                    randomN = Random.Range(0, 7);
                    limitTimer -= 0.3f;
                    StartCoroutine(EnemyAppear(randomN));
                }
            }
        }

        if(PlayerScore.instance.timer > 25f)
        {
            if (timer2 > limitTimer2)
            {
                if (selectEnemy2 == false)
                {
                    randomN = Random.Range(0, 7);
                    limitTimer2 -= 0.3f;
                    StartCoroutine(EnemyAppear2(randomN));
                }
            }
        }
    }

    IEnumerator EnemyAppear(int index)
    {
        selectEnemy = true;
        bourner[index].SetActive(true);
       
        yield return new WaitForSeconds(9f);

        bourner[index].SetActive(false);

        yield return new WaitForSeconds(1f);

        selectEnemy = false;
        timer = 0;
    }

    IEnumerator EnemyAppear2(int index)
    {
        selectEnemy2 = true;
        bourner[index].SetActive(true);

        yield return new WaitForSeconds(9f);

        bourner[index].SetActive(false);

        yield return new WaitForSeconds(1f);

        selectEnemy2 = false;
        timer2 = 0;
    }
}
