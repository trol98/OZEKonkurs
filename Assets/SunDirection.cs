using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SunDirection : MonoBehaviour
{
    public Transform transform;
    public Light light;

    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    transform.rotation.x += 0.01;
    private float mC(int color) // mapColor
    {
        return color / 255;
    }

    public void Morning()
    {   
        light.color = new Color(mC(204), mC(253), mC(247));
        transform.rotation = Quaternion.Euler(3, -35, 0);
    }
    public void Midday()
    {
        light.color = new Color(mC(234), mC(245), mC(172));
        transform.rotation = Quaternion.Euler(65, -35, 0);
    }

    public void Sundown()
    {
        light.color = new Color(mC(197), mC(140),  mC(84));
        transform.rotation = Quaternion.Euler(180, -35, 0);
    }

    void Update()
    {
    }
}
