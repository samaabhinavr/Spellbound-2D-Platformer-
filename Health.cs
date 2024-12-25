using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currenthealth;

    public HealthBar bar;

    void Start()
    {
        maxHealth = currenthealth;
        bar.SetMaxHealth(maxHealth); 
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Spikes")
        {
            TakeDamage(100); 
        }
        if (collision.collider.tag == "Wizard")
        {
            TakeDamage(20);
        }

    }
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        bar.SetHealth(currenthealth); 
    }

    private void FixedUpdate()
    {
        if (currenthealth <= 0)
        {
            FindObjectOfType<LevelManager>().EndGame();
        }
    }
}
