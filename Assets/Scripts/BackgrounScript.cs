using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrounScript : MonoBehaviour
{
    [SerializeField] Vector2 scrollVelocity;

    Material material;
    public Texture2D[] texturas;
    void Awake()
    { 
        material = GetComponent<Renderer>().material;
        material.mainTexture = texturas[Random.Range(0,texturas.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += scrollVelocity * Time.deltaTime;
        
    }
}
