using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuerzDeAlejamiento : MonoBehaviour 
{
    // llamar al script eperaciones y tomar valores de el game object txt
    
    // definir radio de alejamiento

    public float radioDeAlejamiento = 10f;
    
    // definir fuerza de alejamiento
    public float fuerzaDeAlejamiento = 10f;
    // definir radio de alejamiento que nos da eperaciones
    public leerTexto readText;

    // definir posicion de el player
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        // definir posicion de el player
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        float distancia;

        // definir distancia entre el player y el objeto

        distancia = Vector3.Distance(transform.position, player.position);
        
        
        // si la distancia es menor que el radio de alejamiento
        if (distancia < radioDeAlejamiento)
        {
            // definir direccion de alejamiento
            Vector3 direccionDeAlejamiento = transform.position - player.position;
            // definir fuerza de alejamiento
            float fuerza = fuerzaDeAlejamiento / distancia;
            // definir fuerza de alejamiento
            direccionDeAlejamiento = direccionDeAlejamiento.normalized * fuerza;
            // definir fuerza de alejamiento
            GetComponent<Rigidbody>().AddForce(direccionDeAlejamiento);
        }else
        if (distancia > radioDeAlejamiento)
        {
            Vector3 direccionDeAsercamiento2 = player.position - transform.position ;
            
            float fuerza = fuerzaDeAlejamiento / (distancia*2);

            direccionDeAsercamiento2 = direccionDeAsercamiento2.normalized * fuerza;

            GetComponent<Rigidbody>().AddForce(direccionDeAsercamiento2);

        }
        
        
    }
    // ditancia = raiz((K*q)/epsilon)
}
