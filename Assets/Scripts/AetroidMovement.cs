using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AetroidMovement : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
