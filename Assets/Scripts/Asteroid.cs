using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    public bool isRight;
    public bool isLeft;
    public bool isUp;
    public bool isDown;
    Vector2 tarjet;

    public Transform leftPoint;
    public Transform rightPoint;

    void Start()
    {
        tarjet = PlayerMovement.instance.transform.position;
    }

   
    void Update()
    {
         tarjet = PlayerMovement.instance.transform.position;

        if (isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            Vector2.MoveTowards(transform.position, leftPoint.position, speed * Time.deltaTime);
            //transform.Translate(tarjet * speed * Time.deltaTime);
        }

        if(isLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            //transform.Translate(tarjet * speed * Time.deltaTime);
        }

        if(isUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            //transform.Translate(tarjet * speed * Time.deltaTime);
        }

        if(isDown)
        {
            transform.Translate((Vector2.down * speed * Time.deltaTime));
            //transform.Translate(tarjet * speed * Time.deltaTime);
        }
    }
}
