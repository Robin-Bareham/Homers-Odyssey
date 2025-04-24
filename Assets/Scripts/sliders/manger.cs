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

    public blueGuideDetection blue_light;
    public greenGuideDetection green_light;
    public redGuideDetection red_light;
    public yellowGuideDetection yellow_light;

    

    


    bool game = true;
    int lifeCap = 0;
    

    // Start is called before the first frame update
    void Start()
    {
       timer.setTime(20);
       blue_light.enabled = false;
       green_light.enabled = false;
       red_light.enabled = false;
       yellow_light.enabled = false;
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

            if(blue_light.inZone)
            {
                blue_light.enabled = true;
            }

            if(green_light.inZone)
            {
                green_light = true;
            }


           
        }

        else if (!game)
        {
            

            if (lifeSystem.timeLoss())
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
