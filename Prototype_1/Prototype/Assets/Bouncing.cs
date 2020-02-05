using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour {
    public GameObject PlayerCtrl;


    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider PlayerCtrl)
    {

        PlayerCtrl.GetComponent<Rigidbody>().AddForce(0, 50000.0f * Time.deltaTime, 0);

    }
}
