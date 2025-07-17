using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //utilized for UI Image
using TMPro; 

public class HealthDisplay : MonoBehaviour
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
