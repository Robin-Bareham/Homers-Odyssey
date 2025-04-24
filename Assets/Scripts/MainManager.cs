using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    private int score = 0;
    private int lives = 3;

    private void Awake()
    {
        if(Instance != null) 
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void setScore(int t_score) {  score = t_score; }
    public int getScore() { return score; }
    public int getLives()  { return lives; }
    public void setLives(int t_lives) {  lives = t_lives;  }
}
