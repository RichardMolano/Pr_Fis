using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerza : MonoBehaviour
{
    public leerTexto cosita;
    public Transform jugador;
    public Transform text1;
    // Start is called before the first frame update
    private string valores = "";
    void Start()
    {
        jugador= GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, jugador.position);
    }
}
