﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simulacionej1 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los dos numeros ingresados son iguales");
        }
        else
        {
            Debug.Log("Los numeros ingresados no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
