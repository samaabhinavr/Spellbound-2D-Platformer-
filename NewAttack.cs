using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class  NewAttack:MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public float AttackDamage = 20;
    public Transform attackposition;
    public float Range;
    public LayerMask whatIsEnemies;
    private int damage;

    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Collider2D[] Wizard = Physics2D.OverlapCircleAll(attackposition.position, Range, whatIsEnemies);
                for (int i = 0; i < Wizard.Length; i++)
                {
                    Wizard[i].GetComponent<EnemyHealth>().minusDamage(AttackDamage);
                    timeBtwAttack = startTimeBtwAttack;
                }
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackposition.position, Range);
    }

}