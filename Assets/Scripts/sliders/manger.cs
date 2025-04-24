using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using System;

public class manager : MonoBehaviour
{
    
    
    public TimeSystem timer;
    public LifeSystem lifeSysytem;
    bool game = true;

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

            // checks if time is over;
            bool timeOver = timer.getTimeOver();

            // stops game updates if timer is depleated
            if(timeOver)
            {
                Debug.Log("time over");
                game = false;
            }
        }

        else if (!game)
        {
            SceneManager.LoadScene("Catch Uranium", LoadSceneMode.Single);
        }
        
    }
}
