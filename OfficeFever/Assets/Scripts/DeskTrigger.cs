using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTrigger : MonoBehaviour
{

    //Leaving papers to desk
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Desk")
        {
            if(this.tag == "Pick")
            {
                StackManager.instance.Leave(this.gameObject);
            }
            
        }
    }
}
