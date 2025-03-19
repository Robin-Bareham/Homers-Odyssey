using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject rod;
    public Transform spawn_point;
    public GameObject instruction_ui;
    public GameObject timer_ui;
    public TextMeshProUGUI seconds_left;
    public float max_x;
    public float rod_timer = 0;
    public float seconds = 100;
    public float action = 50;
    //Private
    private float additive;
    private bool first_time= true;
    private bool minigame_over = false;
    private void Start()
    {
        additive = action;
        instruction_ui.SetActive(true);
        timer_ui.SetActive(false);
        seconds_left.text = seconds.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (!minigame_over) 
        {
            if (rod_timer > action)
            {
                spawnRod();
                action += additive;
                if (first_time)
                {
                    instruction_ui.SetActive(false);
                    timer_ui.SetActive(true);
                    first_time = false;
                }
            }
            if (first_time == false) // Shows countdown timer
            {
                seconds -= Time.deltaTime;
                int temp_visual = (int)seconds;
                seconds_left.text = temp_visual.ToString();
                if (temp_visual <= 0)
                {
                    seconds_left.text = "0";
                    minigame_over = true;
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

}
