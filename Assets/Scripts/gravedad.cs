using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gravedad : Menu
{
    private float grav;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        grav = (vel + car) / mas;
        Physics.gravity =  new Vector3(0,grav,0);
        
    }
}
