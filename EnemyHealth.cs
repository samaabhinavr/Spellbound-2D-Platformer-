using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float EnemyMaxHealth = 100;
    float enemycurrenthealth;

    private void Start()
    {
        enemycurrenthealth = EnemyMaxHealth; 
    }

    public void minusDamage(float edamage)
    {
        
        enemycurrenthealth -= edamage;
        if (enemycurrenthealth <= 0) Dead(); 

    }

    public void Dead()
    {
        Destroy(gameObject); 
    }
}
