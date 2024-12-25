using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishPoint : MonoBehaviour
{
    public bool LevelCompleted = false;
    public Escript E;
    public GameObject portal; 

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
       switch (collision.gameObject.tag)
        {

            case "Player":

                SceneManager.LoadScene(3); 

                break; 
        }

    }
}
