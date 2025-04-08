using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMonedas : MonoBehaviour
{

    public int Cantidad;
    public string Moneda;

    // Start is called before the first frame update
    void Start()
    {
        if (Cantidad < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }else if (Moneda=="D") {
            Debug.Log(Cantidad * 1075 + " " + "Dolares");
         }
        else if (Moneda == "E")
        {
            Debug.Log(Cantidad * 1174 + " " + "Euros"); 
         }
        else if (Moneda == "R")
        {
            Debug.Log(Cantidad * 225 + " " + "Reales");
         }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
         }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
