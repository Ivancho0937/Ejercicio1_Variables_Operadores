using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class ListasScript : MonoBehaviour
{
    public List<int> listadoNumeros = new List<int>();

    private void Start()
    {
        listadoNumeros.Add(5);
        listadoNumeros.Add(7);
        listadoNumeros.Add(8);



        Debug.Log(listadoNumeros[0]); //imprime en consola al dato introducido teniendo en cuenta su indice
        Debug.Log(listadoNumeros.Count);//Imprime la cantidad de datos en la lista
        listadoNumeros.Remove(7);//remueve el elemento(?) de la lista
        listadoNumeros.Insert(0,10);//inserta un dato en determinada posicion dada por el indice
        
        

    }
   




}
