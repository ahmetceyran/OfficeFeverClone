using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int coins;

    
    //Showing player coins on screen with gui
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Coins : " + coins);
    }
}
