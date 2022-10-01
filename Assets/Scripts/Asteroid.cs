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

    void Start()
    {
        
    }

   
    void Update()
    {
        if (isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if(isLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if(isUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if(isDown)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
