using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    public float speed;

    private float movX, movY;

    private bool dashActivated;
    
    

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        dashActivated = false;
    }

   
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (dashActivated != true)
            {
                StartCoroutine(DashCooldown());
            }
        }
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }

    IEnumerator DashCooldown()
    {
        speed = 15.5f;
        dashActivated = true;

        yield return new WaitForSeconds(0.3f);

        speed = 6.5f;

        yield return new WaitForSeconds(0.5f);

        dashActivated = false;
    }
}
