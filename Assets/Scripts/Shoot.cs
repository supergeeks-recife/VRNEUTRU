using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{   
    public GameObject bullet;
    public float speed;
    public int pontos;

    Rigidbody rig_bullet;
    

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject createdBullet = Instantiate(bullet);
            createdBullet.transform.position = transform.position;
            rig_bullet = createdBullet.GetComponent<Rigidbody>();
            
            Camera cam = Camera.main;
            rig_bullet.velocity = cam.transform.rotation * Vector3.forward * speed;
        }
    }
}
