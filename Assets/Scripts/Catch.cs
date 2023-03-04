using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Destructible"))
        {
            Debug.Log("Destructible");
            collision.gameObject.SetActive(false);
        }
    }
}
