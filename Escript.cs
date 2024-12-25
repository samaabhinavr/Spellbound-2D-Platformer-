using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escript : MonoBehaviour
{
    public bool ECollected = false;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ECollected = true;
            Debug.Log("E is Collected");
            Destroy(gameObject); 
        }
    }
}
