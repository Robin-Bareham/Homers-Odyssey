using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using System;

public class manager : MonoBehaviour
{
    
    public TextMeshProUGUI DisplayTimer;
    public TimeSystem timer;
    public LifeSystem lifeSystem;
    bool game = true;
    int lifeCap = 0;
    bool loss = false;

    // Start is called before the first frame update
    void Start()
    {
       timer.setTime(2);
    }

    // Update is called once per frame
    void Update()
    {
        if(game)
        {
            //updates timer (1 tick per sec)
            timer.updateTimer();
            DisplayTimer.text = timer.getIntTime().ToString();

            // checks if time is over;
            bool timeOver = timer.getTimeOver();

            // stops game updates if timer is depleated
            if(timeOver)
            {
                Debug.Log("time over");

                
                
                game = false;

                timer.setTime(-1);
            }
        }

        else if (!game)
        {
            

            if (lifeSystem.timeLoss());
            {

                while(lifeCap < 1)
                {
                lifeSystem.lives = lifeSystem.lives -1;
                lifeSystem.changeLives();
                Debug.Log("Lives: " + lifeSystem.lives);
                lifeCap ++;
                }
                
                    
            }
                
                
            
            
            SceneManager.LoadScene("Catch Uranium", LoadSceneMode.Single);
            
        }
        
    }
}
