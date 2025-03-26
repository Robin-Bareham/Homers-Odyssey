using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using System;


public class VMHub : MonoBehaviour
{
    public LifeSystem Playerlives;
    public TimeSystem Playertime;
    public TextMeshProUGUI DisplayTimer;
    private int timer= 10;
    private float TempTimer = 0f;
    private bool GameOver;
     

    
    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        Playertime.setTime(10);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == false)
        {
            Playertime.updateTimer(); //Updates countdown

            DisplayTimer.text = "Seconds left: " + Playertime.getIntTime().ToString();
        }
        
    }

    /*private void Countdown() 
    {
        TempTimer += Time.deltaTime;

        if(TempTimer >= 1f) //Checks if a second has passed
        {
            if (timer >= 0) //If the timer is above 0 
            {
                timer -= 1; TempTimer = 0f; //Counts down + resets second.
                DisplayTimer.text = "Seconds left: " + timer; //Displays the timer
            }
            else
            {
                DisplayTimer.text = "You lose!" + timer;
                GameOver = true; //Player loses
            }
        }
        //Else the suborutine does nothing until TempTime has reached/passed a second
    }*/

    public void ButtonFailed() //A seperate button script will run this in the event they pressed the entered number
    {
        GameOver = true;
        Debug.Log("Vending machine minigame failed!");
    }
}
