using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //utilized for UI Image
using TMPro; 

public class GameManager : MonoBehaviour
{

    public GameObject gameOverPanel;// used for game over screen when you lose
    public GameObject victoryPanel; // used for victory screen when you win





    public AudioSource theMusic; // used to call music for game

    public bool startPlaying; // used to start the music 

    public BeatScroller theBS; // Controls Beatscroller script; makes notes fall

    public static GameManager instance; // used for any script to recognize only instance of GameManager

    public int currentScore; // used to keep track of the total score
    public int scorePerNote = 100; // hitting each note gives you a score (can change how much anote gives you)

    //public Text scoreText;
    public TextMeshProUGUI scoreText;

    public HealthDisplay healthDisplay; // used to make an instance of HealthDisplay script for losing hearts for missing notes


    private int successfulHits = 0;// used to track every 3rd hit for enemy health bar

    public EnemyHealthDisplay enemyHealthDisplay; // instance of EnemyHealthDisplay code (Drag EnemyHealthDisplay component here in Inspector)




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

    /* // CHANGE THIS BACK IF ONE UNDER THIS IS TWEAKING 
    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        currentScore += scorePerNote;
        scoreText.text = "Score: " + currentScore; 
    }
    */

    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        currentScore += scorePerNote;
        scoreText.text = "Score: " + currentScore;

        successfulHits++;

        // Every 3rd note hit, damage the enemy
        if (successfulHits % 3 == 0)
        {
            if (enemyHealthDisplay != null)
            {
                enemyHealthDisplay.health--;

                if (enemyHealthDisplay.health <= 0)
                {
                    //Debug.Log("Enemy Defeated!");
                    TriggerVictory(); 
                }
            }
        }
    }


    public void NoteMissed()
    {
        Debug.Log("Missed Note");

        if (healthDisplay != null)
        {
            healthDisplay.health--; // Decrease health

            if (healthDisplay.health <= 0)
            {
                TriggerGameOver();
            }
        }
    }

    void TriggerGameOver()
    {
        Debug.Log("Game Over triggered.");
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // pause the game (optional)
    }

    public void TriggerVictory()
    {
        Debug.Log("Victory triggered.");
        victoryPanel.SetActive(true);
        Time.timeScale = 0f; // pause the game (optional)
    }

}
