using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed = 1.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveObject ();
        
    }

    private void moveObject()
    {
        transform.Translate (-speed * Time.deltaTime , 0f, 0f);
    }
}
