using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAsteroid : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        
    }
}
