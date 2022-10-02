using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleElevator : MonoBehaviour
{
    public float speed;
    public GameObject meteorit;
    public float limitTime;
    float posY;
    void Start()
    {
        posY = transform.position.y;
        StartCoroutine(ThrowMeteorit());
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x,posY);
        if (posY > 4.5f || posY < -4.5f)
        {
            speed *= -1;
        }
        posY += speed*Time.deltaTime;
    }

    IEnumerator ThrowMeteorit()
    {
        while (true) 
        { 
        yield return new WaitForSeconds(limitTime);
        GameObject pref = Instantiate(meteorit, transform.position, Quaternion.identity);
        Destroy(pref, 15.5f);
            if (limitTime > 1.5f)
            {
            limitTime -= 2f;
            }
            else
            {
                limitTime = 1.5f;
            }
        }
    }
}
