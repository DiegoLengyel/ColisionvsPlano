using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadEsfera = 7.0f;

    public bool pararDerecha;
    // Start is called before the first frame update

    

    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        pararDerecha = Physics.Raycast(transform.position, Vector3.right, .67f);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!pararDerecha)
        {
            if(Input.GetKey("right")){
                transform.position -= Vector3.left * velocidadEsfera * Time.deltaTime;
            }
        }

        if(Input.GetKey("left")){
            transform.position -= Vector3.right * velocidadEsfera * Time.deltaTime;
        }
    }
}
