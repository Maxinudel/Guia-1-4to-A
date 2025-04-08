using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMonedas : MonoBehaviour
{

    public float montoAConvertir;
    public string moneda;

    // Start is called before the first frame update
    void Start()
    {
        if (montoAConvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }else if (moneda=="D") {
            Debug.Log(montoAConvertir * 1075 + " " + "Dolares");
         }
        else if (moneda == "E")
        {
            Debug.Log(montoAConvertir * 1174 + " " + "Euros"); 
         }
        else if (moneda == "R")
        {
            Debug.Log(montoAConvertir * 225 + " " + "Reales");
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
