using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //utilized for UI Image
using TMPro;
public class StartButton : MonoBehaviour
{
    public GameObject buttonObject;

    public void OnStartClick()
    {
        buttonObject.SetActive(false); // Hides the button
        Debug.Log("Game Started!");
        // Add other start-game logic here (like enabling spawns)
    }
}
