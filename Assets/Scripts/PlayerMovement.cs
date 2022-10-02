using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;

    private Rigidbody2D rb;
    private Vector2 moveInput;

    public float speed;

    private float movX, movY;

    private bool dashActivated;
    public bool isAlive;
    //public GameObject textGameOver;

    [SerializeField] private TrailRenderer tr;  

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        dashActivated = false;
        isAlive = true;
    }

   
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");

        if (isAlive != false)
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (dashActivated != true)
                {
                    StartCoroutine(DashCooldown());
                }
            }
        }
        else
        {
            StartCoroutine(DeadRespawn());
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
        tr.emitting= true;  
        yield return new WaitForSeconds(0.3f);

        speed = 6.5f;
        tr.emitting = false;

        yield return new WaitForSeconds(0.5f);

        dashActivated = false;
       
    }

    IEnumerator DeadRespawn()
    {
        //textGameOver.SetActive(true);

        yield return new WaitForSeconds(1.6f);

        SceneManager.LoadScene("GAME");
        isAlive = true;
        //PlayerScore.instance.km = 0;
        //textGameOver.SetActive(false);

    }
}
