using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollider : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private float coint = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coint")
        {
             Destroy(other.gameObject);
             coint++;
             scoreText.text = ""+coint;
        }

        if (other.tag=="health")
        {
            Destroy(other.gameObject);
          
        }
    }
}
