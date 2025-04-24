using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Public:
    public GameObject rod; //Rods
    public Transform spawn_point; //Spawning area
    public GameObject instruction_ui;
    public GameObject timer_ui;
    public GameObject score_ui;
    public TextMeshProUGUI seconds_left;
    public float max_x; //Limits for Rods Spawn
    public float rod_timer = 0; //Rod spawning timer
    public float action = 50; // Rod spawning timer
    public float seconds = 100; //Seconds to complete minigame
    public LifeSystem life_system; //Life Scripts
    public TimeSystem time_system; // Time Script
    //Private:
    private float additive;
    private bool first_time= true; //First time activating
    private bool minigame_over = false;
    private bool won = false;
    private int lives = 3;
    private void Start()
    {
        additive = action;
        instruction_ui.SetActive(true);
        timer_ui.SetActive(false);
        score_ui.SetActive(false);
        seconds_left.text = seconds.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (!minigame_over) //If it's not ended
        {
            if (rod_timer > 3) //After 3 seconds hide UI
            { instruction_ui.SetActive(false); }
            if (rod_timer > action) //After time spawn a rod
            {
                spawnRod();
                action += additive;
                if (first_time) // After spawning first rod, also show timer + score UI
                {
                    timer_ui.SetActive(true);
                    score_ui.SetActive(true);
                    time_system.setTime(seconds);

                    first_time = false;
                }
            }
            if (first_time == false) // Shows countdown timer
            {
                time_system.updateTimer();
                seconds_left.text = time_system.getIntTime().ToString();
                if(time_system.getTimeOver() == true) 
                {
                    seconds_left.text = "0";
                    minigame_over = true;
                    won = true;
                }
            }
            rod_timer += Time.deltaTime; //Increases rod timer
        }
            
    }

    private void spawnRod() 
    {
        Vector3 spawnPos = spawn_point.position;
        spawnPos.x = Random.Range(-max_x, max_x);
        Instantiate(rod,spawnPos, Quaternion.identity);
    }

    public void setMinigameFailed(bool value)
    {
        minigame_over = value;
        if(value == true)
        {
            life_system.changeLives();
            lives--;
            //Move scene onto next game
        }
    }

    public bool getMinigameOver() { return minigame_over; }

    public bool getWon() { return won; }
    public int getLives() { return lives; }
    
    public void setLives(int temp_lives) { lives = temp_lives; }
}
