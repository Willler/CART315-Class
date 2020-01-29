using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{

    public GameObject theCamera;
    public GameObject create;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //(1) means it is the second button, 0 being the left mouse button
        count = count + 1;
        if (count >= 6) count = 0;
        if (Input.GetMouseButton(1) && count == 0)
        {
            RaycastHit hit;
            Ray ray = theCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, Mathf.Infinity);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                 
                Instantiate(create, hit.point, Quaternion.identity);
            }
        }
    }
}
