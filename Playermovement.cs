using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{


    public CharacterController2D controller;
    public Health health;
    public Animator animator; 

    float Horizontalspeed = 0f;
    public float Runspeed = 40f;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {

        Horizontalspeed = Input.GetAxisRaw("Horizontal") * Runspeed;

        animator.SetFloat("Speed", Mathf.Abs(Horizontalspeed));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move(Horizontalspeed * Time.fixedDeltaTime, false, jump);
        jump = false;

        GameObject player = GameObject.FindWithTag("Player");
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

        if (rb.position.y < 0)
        {

            FindObjectOfType<LevelManager>().EndGame();
        }
        
    }

    public IEnumerator Knock(float KnockDuration, float power, Vector3 Direction)
    {
        float timer = 0;
        GameObject player = GameObject.FindWithTag("Player");
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>(); 

        while (KnockDuration > timer)
        {
            timer += Time.deltaTime;
            rb.AddForce(new Vector3(Direction.x*-20, Direction.y+power, transform.position.z)); 

        }

        yield return 0; 

    }
}





