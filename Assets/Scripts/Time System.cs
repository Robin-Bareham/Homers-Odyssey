using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    private float max_time = 0;
    private float current_time = 0;
    private int current_time_int = 0;
    private bool time_over = false;
 
     public void setTime(float temp_time) 
    {
        max_time = temp_time;
        current_time = max_time;
    }

    public float getFloatTime() 
    {
        return current_time;
    }

   public int getIntTime() 
    {
        return current_time_int;
    }
    public bool getTimeOver() 
    {
        return time_over;
    }

    public void updateTimer() 
    {
        current_time -= Time.deltaTime; //Counts down
        current_time_int = (int)current_time; //Makes it into an int
        if (current_time_int <= 0) //If int has reached zero
        {
            time_over = true; //Time over has occoured
        }
    }
}
