using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_obj : MonoBehaviour
{

    // Velocidad de movimiento
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtenemos las teclas presionadas
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Aplicamos el movimiento en el eje x y z
        transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0.0f, verticalInput * speed * Time.deltaTime));
    }
}
