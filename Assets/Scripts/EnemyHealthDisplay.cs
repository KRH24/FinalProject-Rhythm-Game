using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //utilized for UI Image
using TMPro;
/*
public class EnemyHealthDisplay : MonoBehaviour
{
    public int health = 5; // Current enemy health (number of hearts)
    public Image[] hearts; // UI Images representing hearts
    public Sprite fullHeart; // Sprite for full (red) heart
    public Sprite emptyHeart; // Sprite for empty (gray) heart

    void Start()
    {
        // Clamp health to max hearts at start
        if (health > hearts.Length)
            health = hearts.Length;

        UpdateHearts();
    }

    void Update()
    {
        // Optionally update hearts every frame if health can change dynamically
        // But better is to call UpdateHearts() only when health changes
    }

    public void UpdateHearts()
    {
        Debug.Log($"Updating hearts: health={health}, hearts.Length={hearts.Length}");

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
                hearts[i].enabled = true;
                Debug.Log($"Heart {i} set to FULL");
            }
            else
            {
                hearts[i].sprite = emptyHeart;
                hearts[i].enabled = true;
                Debug.Log($"Heart {i} set to EMPTY");
            }
        }
    }
}
*/


public class EnemyHealthDisplay : MonoBehaviour
{
    public int health; 
    public int numOfHearts;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = numOfHearts; // Start full
    }

    // Update is called once per frame
    void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }


        for (int i = 0; i < hearts.Length; i++)// for loop to check hearts in array; checks to see if each heart should be full or empty
        {

            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;// checks hearts to see if it should be turned on 
            }
            else
            {
                hearts[i].enabled = false;// turns off any hearts that should not be active
            }
        }
    }     
}

