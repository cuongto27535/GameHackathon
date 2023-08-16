using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionControlBoom : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 direction = Vector3.up;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
