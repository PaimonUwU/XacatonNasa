using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Generator : MonoBehaviour
{
    public static Generator instance;

    public GameObject meteorit;
    private bool canThrow;
    private float time;
    public Transform leftPoint;
    public Transform rightPoint;
    private bool isRight;
    public float speed;
    private Rigidbody2D rb;
    private float limitTime;

    private void Start()
    {
        canThrow = true;
        time = 0;
        limitTime = Random.Range(4, 7);

        
        leftPoint.SetParent(null);
        rightPoint.SetParent(null);
        rb = GetComponent<Rigidbody2D>();

        isRight = true;
    }

    private void Update()
    {
        //Movement Function
        if (Vector2.Distance(transform.position, rightPoint.position) < 1.5f)
        {
            isRight = false;
        }
        else if(Vector2.Distance(transform.position, leftPoint.position) < 1.5f)
        {
            isRight = true;
        }

        if (isRight == true)
        {
            rb.velocity = new Vector3(speed * Time.deltaTime * 10, 0);
        }
        else
        {
            rb.velocity = new Vector3(-speed * Time.deltaTime * 10, 0);
        }

        time += Time.deltaTime;

        if(time > limitTime)
        {
            if (canThrow == true)
            {
                StartCoroutine(ThrowMeteorit());
            }
        }
        Debug.Log(limitTime);
        if(limitTime < 1.5)
        {
            limitTime = 1.5f;
        }
    }

    IEnumerator ThrowMeteorit()
    {
        canThrow = false;
        GameObject pref = Instantiate(meteorit, transform.position, Quaternion.identity);
        Destroy(pref, 6.5f);

        yield return new WaitForSeconds(limitTime);

        if (limitTime > 1.5f)
        {
            limitTime -= 1.8f;
        }
        time = 0f;
        canThrow = true;
    }
}
