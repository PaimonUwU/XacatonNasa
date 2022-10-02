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
        Debug.Log(limitTimer);
        timer += Time.deltaTime;
        if(limitTimer <= 1.7f)
        {
            limitTimer = 1.7f;
        }

        if(PlayerScore.instance.timer > 15)
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
       

        yield return new WaitForSeconds(5f);

        bourner[index].SetActive(false);

        yield return new WaitForSeconds(3f);

        selectEnemy = false;
        timer = 0;
    }
}
