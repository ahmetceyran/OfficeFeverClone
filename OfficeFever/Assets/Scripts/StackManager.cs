using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;

    [SerializeField] private float PickdistanceBetweenObjects;
    [SerializeField] private float LeavedistanceBetweenObjects;
    [SerializeField] private Transform PickprevObject;
    [SerializeField] private Transform Pickparent;
    [SerializeField] private Transform LeaveprevObject;
    [SerializeField] private Transform Leaveparent;
    [SerializeField] private GameObject Coin;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }



    //Picking up and stacking papers
    public void PickUp(GameObject pickedObject, bool downOrUp = true)
    {

        pickedObject.transform.parent = Pickparent;
        Vector3 desPos = PickprevObject.localPosition;
        desPos.y += downOrUp ? PickdistanceBetweenObjects : -PickdistanceBetweenObjects;
        
        pickedObject.transform.localPosition = desPos;
        PickprevObject = pickedObject.transform;
    }

    //Leaving and stacking papers
    public void Leave(GameObject pickedObject, bool downOrUp = true)
    {

        pickedObject.transform.parent = Leaveparent;
        Vector3 desPos = LeaveprevObject.localPosition;
        desPos.y += downOrUp ? LeavedistanceBetweenObjects : -LeavedistanceBetweenObjects;

        pickedObject.transform.localPosition = desPos;
        LeaveprevObject = pickedObject.transform;
        Coin.GetComponent<CoinInstant>().stopSpawning = false;//When we left papers to desk this code will enable coin spawn
    }




}
