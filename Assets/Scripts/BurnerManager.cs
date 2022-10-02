using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerManager : MonoBehaviour
{
    private float timer;
    private int randomN;
    private bool selectEnemy;
    private float limitTimer;

    public GameObject[] bourner;
   
    void Start()
    {
        timer = 0;
        selectEnemy = false;
        limitTimer = 6;
    }

   
    void Update()
    {
        //Debug.Log(limitTimer);
        //Limita el timer para que no se reduzca mas de el limite
        timer += Time.deltaTime;

        if(limitTimer <= 1.7f)
        {
            limitTimer = 1.7f;
        }

        if(PlayerScore.instance.timer > 7)
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
}
