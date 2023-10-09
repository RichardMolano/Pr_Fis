using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leerTexto : MonoBehaviour
{
    // Start is called before the first frame update
    private string input1;
    private string input2;
    private string input3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeerTextoEntrada1( string valor)
    {
        input1 = valor;
        Debug.Log(input1);
    }
    public void LeerTextoEntrada2(string valor2)
    {
        input2 = valor2;
        Debug.Log(input2);
    }
    public void LeerTextoEntrada3(string valor3)
    {
        input3 = valor3;
        Debug.Log(input3);
    }
}
