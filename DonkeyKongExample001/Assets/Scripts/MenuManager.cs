﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    
    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(1);
        }
    }
}
