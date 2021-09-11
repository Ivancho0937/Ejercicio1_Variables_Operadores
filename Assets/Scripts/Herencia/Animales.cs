using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animales
{
    public string color;

    public int patas;

    public Animales(string newColor, int newPatas)
    {
        color = newColor;
        patas = newPatas;
        
    }

   
    public string habilidad(string habilidadAnimal)
    {
        return habilidadAnimal;
    }

    
    
}
