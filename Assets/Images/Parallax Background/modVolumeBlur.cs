using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class modVolumeBlur : MonoBehaviour
{
    public Volume vol;
    DepthOfField dof;
    public float test;
    // Start is called before the first frame update
    void Start()
    {
        if(vol.profile.TryGet<DepthOfField>(out dof))
        {
            dof.focalLength.value = 65;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (vol.profile.TryGet<DepthOfField>(out dof))
        {
            dof.focalLength.value = test;
        }

    }
}
