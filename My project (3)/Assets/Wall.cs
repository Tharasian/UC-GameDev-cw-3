using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class Wall : MonoBehaviour
{
    public float speed;
    private Rigidbody2D RB;
    void Start() { 
    
        RB = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }
    void move() {
        RB.velocity = new Vector2(Input.GetAxis("Horizontal"), 0) * speed ;
     
    }
}
