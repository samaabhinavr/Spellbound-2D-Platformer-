using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public int force = 500; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = GameObject.FindWithTag("Player");
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * force);
    }
}