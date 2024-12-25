using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascript : MonoBehaviour
{
    public bool ACollected = false;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ACollected = true;
            Debug.Log("A is Collected");
            Destroy(gameObject);
        }
    }
}
