﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    private const int ID = 1;
    private int contador = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Objeto: " + gameObject.name + " con ID: " + ID);   
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Iteración " + contador + " de " + gameObject.name);
        contador++;
    }
}
