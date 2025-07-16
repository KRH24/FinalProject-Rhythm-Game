using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
    Makes arrows fall down

    NOTE : CHANGE BEAT TEMPO IN SCRIPT IN NOTEHOLDER (INSPECTOR) 

*/

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;

    public bool hasStarted; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beatTempo = beatTempo / 60f; // helps arrows match beat tempo of music
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            /*if (Input.anyKeyDown)
            {
                hasStarted = true;
            }*/ // NO LONGER NEEDED, DONE INE "GameManager.cs" 
            
        } 
        else 
        {
           transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);     
        }
    }
}
