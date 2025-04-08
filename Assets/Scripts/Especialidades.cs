using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Especialidades : MonoBehaviour
{

    public string nombreAlumno;
    public string especialidad;
    public int año;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("Error");
        }else if (año < 1)
        {
            Debug.Log("Error");
        }
        else if (año > 5)
        {
            Debug.Log("Error");
        }else if(año<=2 && año >= 1)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }else if(especialidad != "T" && especialidad != "G" && especialidad != "M" && especialidad != "D" && especialidad != "H" ){
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }else
        {
            Debug.Log("Muchas gracias " + nombreAlumno);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
