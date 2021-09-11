using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBase 
{
    public string color;
    public int patas;

    public AnimalBase(string nuevoColor, int nuevoPatas)
    {
        color = nuevoColor;
        patas = nuevoPatas;

    }


    public string habilidadSalir(string nuevaHabilidad)
    {
        return nuevaHabilidad;
    }

}
