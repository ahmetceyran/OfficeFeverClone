using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //When player hit coin enable coin and set player coin
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerScript>().coins = other.GetComponent<PlayerScript>().coins + 10;
            gameObject.SetActive(false);
        }
    }
}
