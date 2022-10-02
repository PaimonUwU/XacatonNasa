using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleElevator : MonoBehaviour
{
    public float speed;
    public GameObject meteorit;
    public float limitTime;
    float posX,posY;
    public bool horizontal;
    void Start()
    {
        posY = transform.position.y;
        posX = transform.position.x;
        StartCoroutine(ThrowMeteorit());
    }

    void Update()
    {
        if (!horizontal)
        {
            transform.position = new Vector2(transform.position.x, posY);
            if (posY > 4.5f || posY < -4.5f)
            {
                speed *= -1;
            }
            posY += speed * Time.deltaTime;
        }
        else
        {
            transform.position = new Vector2(posX,transform.position.y);
            if (posX > 8 || posX < -8)
            {
                speed *= -1;
            }
            posX += speed * Time.deltaTime;
        }
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
            limitTime -= 0.2f;
            }
            else
            {
                limitTime = 1.5f;
            }
        }
    }
}
