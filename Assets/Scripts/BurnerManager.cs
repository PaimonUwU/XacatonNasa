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
                StartCoroutine(EnemyAppear(randomN));
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
