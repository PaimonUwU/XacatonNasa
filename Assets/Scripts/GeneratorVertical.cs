using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorVertical : MonoBehaviour
{
    public GameObject meteorit;
    private bool canThrow;
    private float time;
    public Transform upPoint;
    public Transform downPoint;
    private bool isUp;
    public float speed;
    private Rigidbody2D rb;
    private float limitTime;

    private void Start()
    {
        canThrow = true;
        time = 0;
        limitTime = Random.Range(4, 7);


        upPoint.SetParent(null);
        downPoint.SetParent(null);
        rb = GetComponent<Rigidbody2D>();

        isUp = true;
    }

    private void Update()
    {
        //Movement Function
        if (Vector2.Distance(transform.position, upPoint.position) < 1.5f)
        {
            isUp = false;
        }
        else if (Vector2.Distance(transform.position, downPoint.position) < 1.5f)
        {
            isUp = true;
        }

        if (isUp == true)
        {
            rb.velocity = new Vector3(0,-speed * Time.deltaTime * 10);
        }
        else
        {
            rb.velocity = new Vector3(0,speed * Time.deltaTime * 10);
        }

        time += Time.deltaTime;

        if (time > limitTime)
        {
            if (canThrow == true)
            {
                StartCoroutine(ThrowMeteorit());
            }
        }
        
        if (limitTime < 1.5)
        {
            limitTime = 1.5f;
        }
    }

    IEnumerator ThrowMeteorit()
    {
        canThrow = false;
        GameObject pref = Instantiate(meteorit, transform.position, Quaternion.identity);
        Destroy(pref, 15.5f);

        yield return new WaitForSeconds(limitTime);

        if (limitTime > 1.5f)
        {
            limitTime -= 0.2f;
        }
        time = 0f;
        canThrow = true;
    }
}
