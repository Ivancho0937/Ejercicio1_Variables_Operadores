using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejecutor_Animales : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Contruimos instancias de animales
        AnimalBase cerdo = new AnimalBase("Rosado",4);
        AnimalBase gallina = new AnimalBase("Blanca", 2);


        string habildiadCerdo = cerdo.habilidadSalir("Masticar");
        string habilidadGallina = gallina.habilidadSalir("cacarear");

        int gallinaCoja = gallina.patas - 1;

        Debug.Log("la habilidad del cerdo es " + habildiadCerdo + " y su color es" + cerdo.color + " su cantidad de patas es " + cerdo.patas);
        Debug.Log("La habilidad de la galliina es " + habilidadGallina + " y tiene " + gallinaCoja + " patas porque piso algo");



    }

    /*
    public new void  habilidadSalir()
    {
        Debug.Log("mastica");
    }
    */
}
