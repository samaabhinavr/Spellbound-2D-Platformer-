using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterScript : MonoBehaviour
{
    public bool GCollected = false;

    void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            GCollected = true;
            Debug.Log("G is Collected");
            Destroy(gameObject);
        }    
    }
}
