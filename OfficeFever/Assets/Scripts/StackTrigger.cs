using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MonoBehaviour
{
    //When player hit the cloned papers stack manager will collect them and make them collected
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Pick")
        {
            StackManager.instance.PickUp(other.gameObject);
            other.gameObject.GetComponent<CollectiablePaper>().MakeCollected();
        }
    }

}
