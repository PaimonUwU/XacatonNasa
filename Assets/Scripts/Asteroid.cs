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

    private float tam;
    public Transform leftPoint;
    public Transform rightPoint;

    void Start()
    {
        tarjet = PlayerMovement.instance.transform.position;

        rb = GetComponent<Rigidbody2D>();

        speed = Random.Range(3.2f, 5.4f);
        tam = Random.Range(0.5f, 0.9f);
        desviationSpeed = Random.Range(-25, 25);
        transform.localScale = new Vector3(tam, tam, tam);
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Explosion"))
        {
            Destroy(gameObject);
        }
    }
}
