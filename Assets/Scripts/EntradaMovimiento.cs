using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntradaMovimiento : MonoBehaviour
{
    public string palabra;
    public GameObject inputField;
    public GameObject textDisplay;
    // Start is called before the first frame update


    public void comprobar()
    {
        palabra = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "fdsff" + palabra;
        
        

        switch (palabra)
        {
            case "arriba":
                Debug.LogError("Sube");
                break;

            default:
                break;
        }
    }
    
}
