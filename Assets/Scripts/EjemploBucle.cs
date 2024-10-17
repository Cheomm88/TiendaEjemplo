using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploBucle : MonoBehaviour
{
    public int[] arrayNumeros;
    // Start is called before the first frame update
    void Start()
    {
        int sumaDeNotas = 0;
        int notaMasBaja = arrayNumeros[0];
        for (int i = 0; i < arrayNumeros.Length; i++)
        {
            sumaDeNotas += arrayNumeros[i];

            if (notaMasBaja > arrayNumeros[i])
            {
                notaMasBaja = arrayNumeros[i];
            }


            Debug.Log("Nota en el ejercicio " + i + " = " + arrayNumeros[i]);
        }

        int notaMedia = sumaDeNotas / arrayNumeros.Length;
        Debug.Log("Nota media " + notaMedia + " nota más baja = " + notaMasBaja);
    }

    
}
