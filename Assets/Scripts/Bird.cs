using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bird : MonoBehaviour
{

    public Rigidbody2D rb;
    public Text score;
    private int num = 0;
    private float speedOfJump = 7f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Fire1")){
        rb.velocity = new Vector2 (0f, speedOfJump);
        }
        score.text = num.ToString();
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Score"){
            num++;        
            return;
        }       
    }
}
