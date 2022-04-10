using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInstant : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject paperParent;
    public bool stopSpawning = false;
    [SerializeField] private float spawnDelay;

    //Spawn as many coins as the number of papers
    public void Spawn()
    {
        if (!stopSpawning)
        {
            for(int i = 0; i < paperParent.transform.childCount-1; i++)
            {
                Invoke("SpawnObject", spawnDelay);
            }
            
        }
        stopSpawning = true;
    }
    //cloning
    public void SpawnObject()
    {
        Instantiate(coin, transform.position, transform.rotation);
        
    }
}
