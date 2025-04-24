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
    private void Start()
    {
        additive = action;
        instruction_ui.SetActive(true);
        timer_ui.SetActive(true);
        score_ui.SetActive(true);
        seconds_left.text = seconds.ToString();
    }
    // Update is called once per frame
    void Update()
    {

            if (first_time) //Start timer 
            {
                time_system.setTime(seconds);
                first_time = false;
            }
            if (rod_timer > 3) //After 3 seconds hide UI
            { instruction_ui.SetActive(false); }
            if (rod_timer > action) //Spawn rods at intervals.
            {
                spawnRod();
                action += additive;
            }

            time_system.updateTimer();
            seconds_left.text = time_system.getIntTime().ToString();
            //If the timer ends
            if(time_system.getTimeOver() == true) 
            {
              //The player won the game, moves onto next scene
              seconds_left.text = "0";
              SceneManager.LoadScene("Vending Machine", LoadSceneMode.Single);
            }
            rod_timer += Time.deltaTime; //Increases rod timer
            
    }
    //Spawning Rods
    private void spawnRod() 
    {
        Vector3 spawnPos = spawn_point.position;
        spawnPos.x = Random.Range(-max_x, max_x);
        Instantiate(rod,spawnPos, Quaternion.identity);
    }

    public void setMinigameFailed(bool value)
    {
        if(value == true)
        {
            //Decreases the lives by one
            life_system.setLives(life_system.getLives()-1);
            life_system.changeLives(); //Update visuals
            SceneManager.LoadScene("Vending Machine", LoadSceneMode.Single);
        }
    }


}
