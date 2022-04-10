using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    [SerializeField] private GameObject Desk;

    //When we left paper several times to desk this code will disable coin spawn again
    void Update()
    {
        if(Desk.transform.childCount < 2)
        {
            Coin.GetComponent<CoinInstant>().stopSpawning = true;
        }
    }
}
