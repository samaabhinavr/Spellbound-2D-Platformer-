using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public bool jailOpen = false;
    public float timer;

    void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            jailOpen = true;
            Debug.Log("Jail is open");
            StartCoroutine("LockJail"); 
        }
    }

    IEnumerator LockJail ()
    {
        yield return new WaitForSeconds(timer);
        jailOpen = true;
        Debug.Log("Jail is closed"); 
    }
}
