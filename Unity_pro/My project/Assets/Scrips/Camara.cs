using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    // definir movimiento de la camara en 3ra persona
    public Transform player;

    
    // Start is called before the first frame update
    void Start()
    {
        // definir posicion de la camara
        transform.position = new Vector3(player.position.x-10, player.position.y + 10, player.position.z - 10);
        // definir rotacion de la camara
        transform.rotation = Quaternion.Euler(60, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // movimiento de la camara en 3ra persona
        transform.position = new Vector3(player.position.x, player.position.y + 10, player.position.z - 10);
    }
}
