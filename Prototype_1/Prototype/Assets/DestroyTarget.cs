﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{

    public int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
    }

    void OnCollisionEnter(Collision other)
    {
        KeepingScore.Score += 5;
        Debug.Log(KeepingScore.Score);
        Destroy(gameObject);
    }
}
