﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotate : MonoBehaviour
{
    public float rotateSpeed;
    public bool isRotating;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isRotating)
        {
            gameObject.transform.localEulerAngles += new Vector3(0,rotateSpeed * Time.deltaTime,0);
        }
    }
}
