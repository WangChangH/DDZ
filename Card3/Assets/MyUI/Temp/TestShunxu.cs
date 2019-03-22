using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShunxu : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Awake");
        Destroy(gameObject, 3);
    }
    void Start()
    {
        Debug.Log("Start");
    }
    
    void Update()
    {
        
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
}
