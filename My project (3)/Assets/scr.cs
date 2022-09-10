using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scr : MonoBehaviour
{
    public float maxSpeed;
    public Rigidbody2D rb;
    private AudioSource srcz;
    public void Start()
    {
       rb = this.GetComponent<Rigidbody2D>();
        srcz = this.GetComponent<AudioSource>();

    }
    private void FixedUpdate()
    {

        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }
    void OnCollisionEnter2D(Collision2D collision) {
        srcz.Play();
    }
   
}
