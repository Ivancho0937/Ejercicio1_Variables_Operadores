using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejecutor : MonoBehaviour
{
    void Start()
    {
        //Contruimos cada instancia de cada animal nombrandolo en una variable especifica,
        //llenamos los parametros con los datos que me pide en el constructor del script padre
        Animales cerdo = new Animales("rosado",4);
        Animales caballo = new Animales("cafe",4);
        Animales gallina = new Animales("blanco",2);
        Animales gallo = new Animales("blanco",2);
        Animales perro = new Animales("gris",4);


        //Creamos variables que almacenen las cadenas de texto que en este caso funcionaran
        //como las habilidades de cada animal
        
        string escapeCerdo = cerdo.habilidad("mastica todo el pasto a su alrededor " +
            "dejando al descubierto la tierra");
        string escapeCaballo = caballo.habilidad("patea la puerta con gran fuerza");
        string escapePerro = perro.habilidad("excava un hoyo lo suficientemente grande para permitir " +
            "que todos los animales salgan del granero");


        //Finalmente imprimimos por consola, usando todos los datos y variables creados
        Debug.Log("el cerdo " + cerdo.color + " que tiene " + cerdo.patas + " patas "
            + escapeCerdo);
        Debug.Log("El perro " + perro.color + ", " + escapePerro + " gracias a sus poderosas " + perro.patas
            + "patas");
        Debug.Log("Finalmente, el caballo " + escapeCaballo + " con sus " + caballo.patas / 2 + " patas traseras, "
            + " permitiendo a los animales escapar de ese horrible lugar");


    }

    
}
