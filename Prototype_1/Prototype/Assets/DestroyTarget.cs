using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{


    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
