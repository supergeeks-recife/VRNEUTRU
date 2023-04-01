using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[]  listOfObjects;
    public int min;
    public int max;

    private GameObject randomObject;

    public float distanceFromSpawn = 10;
    public float spawnInterval;
    private int maxCount;
    private int count;

    void Start()
    {
        maxCount = Random.Range(min, max);
        if(spawnInterval == 0)
        {
            for (int i = 0; i < maxCount; i++)
            {
                Spawn();
            }
        }
        else
        {
            InvokeRepeating("Spawn", 0, spawnInterval);
        }
    }

    void Spawn()
    {
        int index  = Random.Range(0, listOfObjects.Length);
        randomObject = Instantiate(listOfObjects[index]);

        randomObject.transform.parent = transform;

        randomObject.transform.localPosition = 
        new Vector3(Random.Range(transform.position.x - distanceFromSpawn, 
                    transform.position.x + distanceFromSpawn),
                    0,
                    Random.Range(transform.position.y - distanceFromSpawn,
                    transform.position.y + distanceFromSpawn));
        count++;
        
    }
}