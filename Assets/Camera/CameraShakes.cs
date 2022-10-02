using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakes : MonoBehaviour
{
    public static CameraShakes instance;

    private Animator aniCam;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        aniCam = GetComponent<Animator>();
    }

   
    void Update()
    {
       
    }

    public IEnumerator ShakeCam()
    {
        aniCam.SetBool("Shake", true);

        yield return new WaitForSeconds(0.15f);

        aniCam.SetBool("Shake", false);
    }
}
