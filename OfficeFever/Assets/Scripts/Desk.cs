using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{
    [SerializeField] private bool once = false;
    [SerializeField] private GameObject coin;

    void FixedUpdate()
    {
        if(transform.childCount > 1 && !once) //if we left paper spawn coins as paper and delete papers
        {
            coin.GetComponent<CoinInstant>().Spawn();
            DeleteChilds();
        }
    }

    private void DeleteChilds() //Deleting every paper on the desk
    {
        Transform[] transforms = this.GetComponentsInChildren<Transform>();

        foreach (Transform t in transforms)
        {
            if (t.gameObject.tag == "Pick")
            {
                t.gameObject.SetActive(false);
            }
        }
    }

    

}
