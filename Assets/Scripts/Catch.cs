using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    Counter counter;

    void Start()
    {
        counter = FindObjectOfType<Counter>();   
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Destructible"))
        {
            //collision.gameObject.SetActive(false);
            counter.IncrementContador();
        }
    }
}
