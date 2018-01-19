using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    private RaycastHit forwardHit;
    //public LayerMask layerMaskTest;

    int layer;

    void Start()
    {

    }
    
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out forwardHit, Mathf.Infinity, 1<<8))
        {
            Debug.DrawLine(transform.position, forwardHit.point, Color.black);
        }
    }
}
