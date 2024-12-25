using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback1 : MonoBehaviour
{
    private Playermovement player; 
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Playermovement>(); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(player.Knock(0.02f, 200, player.transform.position));
    }
}
