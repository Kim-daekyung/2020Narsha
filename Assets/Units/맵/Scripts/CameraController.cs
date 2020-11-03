using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float left_limit = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec3 = new Vector3();
        vec3.x = player.position.x;
        if (player.position.x < left_limit) vec3.x = left_limit;
        vec3.y = player.position.y + 27.50f;
        vec3.z  = player.position.z;
        transform.position = vec3;
    }
}
