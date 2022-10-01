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
    public float desviationSpeed;
    private Rigidbody2D rb;
    Vector2 tarjet;

    public Transform leftPoint;
    public Transform rightPoint;

    void Start()
    {
        tarjet = PlayerMovement.instance.transform.position;

        rb = GetComponent<Rigidbody2D>();

        desviationSpeed = Random.Range(-10, 10);
    }

   
    void Update()
    {
         tarjet = PlayerMovement.instance.transform.position;

        if (isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            rb.rotation = desviationSpeed;
        }

        if(isLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            rb.rotation = desviationSpeed;
        }

        if(isUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            rb.rotation = desviationSpeed;
        }

        if(isDown)
        {
            transform.Translate((Vector2.down * speed * Time.deltaTime));
            rb.rotation = desviationSpeed;
        }
    }
}
