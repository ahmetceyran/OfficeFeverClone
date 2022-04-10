using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant : MonoBehaviour
{
    [SerializeField] private GameObject paper;
    [SerializeField] private bool stopSpawning = false;
    [SerializeField] private float spawnTime;
    [SerializeField] private float spawnDelay;

    //Spawn papers and repeat it
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(paper, transform.position, transform.rotation);
        if (stopSpawning)//if stop spawning is true cancel it
        {
            CancelInvoke("SpawnObject");
        }
    }
}
