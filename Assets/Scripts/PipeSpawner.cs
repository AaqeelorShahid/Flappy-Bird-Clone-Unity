using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject [] Obstacles ;
    public GameObject PositionOfFab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D col) {

        int rand = Random.Range (0,3);

        if (col.gameObject.CompareTag ("Obstacle")){
            Instantiate (Obstacles [rand], 
            new Vector2 (PositionOfFab.transform.position.x, Obstacles[rand].transform.position.y),
            Quaternion.identity
            );
            Destroy (col.gameObject);

            Debug.Log (rand);
        }
    }
}
