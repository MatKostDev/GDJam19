﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = (int)Input.GetAxis("Vertical");
        float horizontalInput = (int)Input.GetAxis("Horizontal");
    }
}
