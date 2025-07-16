using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //utilized for UI Image
using TMPro; 

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic; // used to call music for game

    public bool startPlaying; // used to start the music 

    public BeatScroller theBS; // Controls Beatscroller script; makes notes fall

    public static GameManager instance; // used for any script to recognize only instance of GameManager

    public int currentScore; // used to keep track of the total score
    public int scorePerNote = 100; // hitting each note gives you a score (can change how much anote gives you)

    //public Text scoreText;
    public TextMeshProUGUI scoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this; 

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()// used to start the game/music once a key has been pressed 
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
               startPlaying = true; 
               theBS.hasStarted = true;

               theMusic.Play();  
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        currentScore += scorePerNote;
        scoreText.text = "Score: " + currentScore; 
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");
    }
}
