using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mscript : MonoBehaviour
{
    public bool MCollected = false;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MCollected = true;
            Debug.Log("M is Collected");
            Destroy(gameObject);
        }
    }
}
