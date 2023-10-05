using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;
    public float x = 1.0f;
    public float y = 5.0f;
    public float z = 1.0f;
    

    void Start()
    {
        player = GameObject.Find("Player").transform;
        CameraFollower cameraFollower = player.GetComponent<CameraFollower>();
        

    }

    void Update()
    {
        

    }
}
