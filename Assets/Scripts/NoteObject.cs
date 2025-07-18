using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    private bool wasHit = false;// used to indicate if the note was hit or not


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                wasHit = true;
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();// tells the GameManager we hit a note (used for debug.log)
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            //Debug.Log("Entered Activator zone!");// used to indiciate notes being near music blocks
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            if (!wasHit)
            {
                GameManager.instance.NoteMissed(); // tells the GameManager we missed a note (used for debug.log)
            }     
        }
    }
}
