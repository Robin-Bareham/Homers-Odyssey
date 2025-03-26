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
    public VMButtons button;
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

            if(Playertime.getIntTime() <= 0)
            {
                VendingMachineFailed();
                Playerlives.changeLives(1); //Loses a life (Substitude the parameter with the returned lives from different scenes.
            }
        }
        
    }

    public void VendingMachineFailed() //A seperate button script will run this in the event they pressed the entered number
    {
        GameOver = true;
        Debug.Log("Vending machine minigame failed!");
    }
}
