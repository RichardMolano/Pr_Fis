using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Eperaciones : MonoBehaviour
{

    // crear varibles y conectar con el objeto txt de unity input textmechpro
    public UnityEngine.UI.InputField txt1;
  




    // Start is called before the first frame update
    void Start()
    {
        // conectar con el objeto txt de unity input
        txt1 = GameObject.Find("txt1").GetComponent<UnityEngine.UI.InputField>();

    

    }

    // Update is called once per frame
    void Update()
    {


// mostrar valor escrito en el campo en pantalla
        Debug.Log(txt1.text);

    

    }
 
    
}
