using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ejerciciosPractica : MonoBehaviour
{
    public float tiempo = 0.0f;
    public Text tiempotext; 


    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        

        tiempo = tiempo + 1 * Time.deltaTime;
        tiempotext.text = tiempo.ToString();

        int contador = (int)tiempo;


        if (contador % 2 == 0)
        {
            GameObject objeto = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            objeto.transform.position = new Vector3(contador, 0, 0);

        }

       
        
       
    }
}                       
