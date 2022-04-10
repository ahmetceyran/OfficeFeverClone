using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiablePaper : MonoBehaviour
{
    [SerializeField] private bool IsCollected;

    //if paper collected once enable it to collect again

    void Start()
    {
        IsCollected = false;
    }


    public bool GetIsCollected()
    {
        return IsCollected;
    }

    public void MakeCollected()
    {
        IsCollected = true;
    }
}
