using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _0219 : MonoBehaviour
{

    Component[] coms;

    void Start()
    {
        transform.position = Vector3.zero;
        Debug.Log(transform.Find("GrandSon").name) ;
        transform.forward = Vector3.forward;
    }
    
    void Update()
    {
        
    }
}
