using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float timeToDie;
    private void Start()
    {
        Destroy(gameObject,timeToDie);
    } 
    // void Update()
    // {
    //     timeToDie -= Time.deltaTime;
    //     if (timeToDie <= 0)
    //     {
    //         Destroy(gameObject);
    //     }
    // }
}
