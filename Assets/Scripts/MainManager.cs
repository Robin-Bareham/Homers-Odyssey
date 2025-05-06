using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    private int score = 0;
    private int lives = 3;
    private bool game_over = false;
    private float timing = 1;
    private float multiplication = 0.9f;
    public float timeNum = 0;

    private void Awake()
    {
        //Debug.Log(score + " MainManager Score 2222222");
        if (Instance != null) 
        {
            Destroy(gameObject);
            return;
        }
        else { Debug.Log(score + " MainManager Score 2222222"); 
        Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    
    public int getScore() { return score; }
    public int getLives()  { return lives; }
    public void setLives(int t_lives) {  lives = t_lives;
        if (lives >= 0) 
        {
            game_over = true;
        }
    }

    public bool getGameOver() {  return game_over; }

    public float getTiming() { return timing; }

    public bool timerChange() 
    {

        if (getScore() % 3 == 0)
        {
          Debug.Log("MainManager Time changed");
          timing = timing * 0.8f;
          return true;
        }
        return false;
    }

    public void setScore(int t_score)
    {
        score = t_score;
        Debug.Log(score + " MainManager Score");
        if (getScore() % 3 == 0)
        {
            Debug.Log("MainManager Time changed" + timing);
            timing = timing * multiplication;
            Debug.Log("MainManager Time changed after" + timing);
        }
    }
}
