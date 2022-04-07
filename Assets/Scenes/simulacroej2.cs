using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simulacroej2 : MonoBehaviour
{

    public float Producto1;
    public float Producto2;
    public float Producto3;

    public float DineroDisponible;

    // Start is called before the first frame update
    void Start()
    {
        float suma3;
        float cuantofalta;
        float cuantosobra;

        suma3 = Producto1 + Producto2 + Producto3;

        cuantofalta = DineroDisponible - suma3;

        cuantosobra = suma3 - DineroDisponible;

        if (suma3 < DineroDisponible)
        {
            Debug.Log("la suma de los 3 productos no supera el dinero disponible y faltan" + cuantofalta + "pesos");
        }
        else
        {
            Debug.Log("la suma de los 3 productos supera el dinero disponible y sobran " + cuantosobra + " pesos");

        }


    }


    // Update is called once per frame
    void Update()
    {

    }
}
    
    
