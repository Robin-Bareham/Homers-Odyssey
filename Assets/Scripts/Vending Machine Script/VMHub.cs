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
    public VMButtons PanelButton;
    public VMItem TestItem;
    private bool GameOver;
    private int DisplayDigits=-1;
    private int RandomDigits;
    private bool Enter = false;

    
    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        Playertime.setTime(10);
        System.Random RND = new System.Random();
        RandomDigits = RND.Next(0000, 10000); //Includes the starting number, excludes end number.
        Debug.Log(RandomDigits);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver == false)
        {
            Playertime.updateTimer(); //Updates countdown

            DisplayTimer.text = Playertime.getIntTime().ToString();

            if (Enter == true)
            {
                if (DisplayDigits == RandomDigits)
                {
                    VendingMachinePassed();                   
                }
                else
                {
                    VendingMachineFailed();
                    Playerlives.changeLives(); //Loses a life (Substitude the parameter with the returned lives from different scenes.)
                }

            }
            else if (Playertime.getIntTime() <= 0)
            {
                VendingMachineFailed();
                Playerlives.changeLives(); //Loses a life (Substitude the parameter with the returned lives from different scenes.)
            }
            
        }
        
    }

    public void VendingMachineFailed() //A seperate button script will run this in the event they pressed the entered number
    {
        GameOver = true;
        Debug.Log("Vending machine minigame failed!");
        //Decreases the lives by one
        Playerlives.setLives(Playerlives.getLives() - 1);
        Playerlives.changeLives(); //Update visuals
        SceneManager.LoadScene("Power Plant Sliders", LoadSceneMode.Single);
    }

    public void VendingMachinePassed()
    {
        GameOver = true;
        Debug.Log("Won the vending machine minigame!");
        SceneManager.LoadScene("Power Plant Sliders", LoadSceneMode.Single);
    }

    public void PressedEnter(int digits) //The EnterButton is pressed
    {
        DisplayDigits = digits;
        Enter = true;
    }
}
