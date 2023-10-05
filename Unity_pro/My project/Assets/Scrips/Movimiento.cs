
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    
    // definir velocidad de el player
    public float velocidad = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movimiento de el player
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");  
        transform.Translate(new Vector3(movimientoHorizontal, 0, movimientoVertical) * velocidad * Time.deltaTime);
    }
}
