using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Rendering;
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
    private BoxCollider2D col;
    //public GameObject textGameOver;
    public Transform deadZone;
    public Transform bombPoint;
    public GameObject bomb;

    public TextMeshProUGUI textBomb;
    private float bombCooldown;
    public GameObject[] iconSprites;

    [SerializeField] private TrailRenderer tr;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        bombCooldown = 35;
        dashActivated = false;
        isAlive = true;
        textBomb.text =  bombCooldown.ToString("00") + "s";
    }

   
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        textBomb.text = bombCooldown.ToString("0") + "s";

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

            bombCooldown -= Time.deltaTime;

            if (bombCooldown <= 0)
            {
                bombCooldown = 0;
                textBomb.text = "Boom!";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GameObject prefBomb = Instantiate(bomb, bombPoint.position, Quaternion.identity);
                    Destroy(prefBomb, 6f);
                    bombCooldown = 25;

                }
            }

            if(bombCooldown < 29)
            {
                iconSprites[0].SetActive(true);
            }
            else
            {
                iconSprites[0].SetActive(false);
            }

            if(bombCooldown < 22)
            {
                iconSprites[1].SetActive(true);
            }
            else
            {
                iconSprites[1].SetActive(false);
            }

            if (bombCooldown < 15)
            {
                iconSprites[2].SetActive(true);
            }
            else
            {
                iconSprites[2].SetActive(false);
            }

            if (bombCooldown < 8)
            {
                iconSprites[3].SetActive(true);
            }
            else
            {
                iconSprites[3].SetActive(false);
            }

            if (bombCooldown == 0)
            {
                iconSprites[4].SetActive(true);
            }
            else
            {
                iconSprites[4].SetActive(false);
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
        //Vector2.MoveTowards(transform.position, deadZone.position, 10 * Time.deltaTime);
        transform.Translate(Vector2.down * 3    * Time.deltaTime);
        col.isTrigger = true;
        //rb.gravityScale = Random.Range(-5,5);
        //rb.velocity += new Vector2(Random.Range(-100, 100), 150);

        //yield return new WaitForSeconds(0.1f);

        //rb.velocity = new Vector2(rb.velocity.x, 50 * Time.deltaTime);

        yield return new WaitForSeconds(3.7f);

        SceneManager.LoadScene("GAME");
        isAlive = true;
        col.isTrigger = false;
       // rb.gravityScale = 0;
        //PlayerScore.instance.km = 0;
        //textGameOver.SetActive(false);

    }
}
