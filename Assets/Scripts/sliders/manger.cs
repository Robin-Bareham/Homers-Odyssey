using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class manager : MonoBehaviour
{
    public TextMeshProUGUI DisplayTimer;
    public TimeSystem timer;
    public LifeSystem lifeSystem;

    public GameObject blueGuide;
    public GameObject greenGuide;
    public GameObject redGuide;
    public GameObject yellowGuide;

    public blueGuideDetection blueBar;
    public greenGuideDetection greenBar;
    public redGuideDetection redBar;
    public yellowGuideDetection yellowBar;

    bool game = true;
    int lifeCap = 0;

    void Start()
    {
        timer.setTime(6 * MainManager.Instance.getTiming());

        float[] yPositions = { -1.7f, 1.9f, -0.5f, 0.6f };
        System.Random rnd = new System.Random();

        // Shuffle the yPositions array so each guide gets a unique Y
        for (int i = 0; i < yPositions.Length; i++)
        {
            int randIndex = rnd.Next(i, yPositions.Length);
            float temp = yPositions[i];
            yPositions[i] = yPositions[randIndex];
            yPositions[randIndex] = temp;
        }

        // Assign unique Y positions
        SetYPosition(blueGuide, yPositions[0]);
        SetYPosition(greenGuide, yPositions[1]);
        SetYPosition(redGuide, yPositions[2]);
        SetYPosition(yellowGuide, yPositions[3]);
    }

    void SetYPosition(GameObject obj, float newY)
    {
        Vector3 pos = obj.transform.position;
        pos.y = newY;
        obj.transform.position = pos;
    }

    void Update()
    {
        if (game)
        {
            timer.updateTimer();
            DisplayTimer.text = timer.getIntTime().ToString();
            bool timeOver = timer.getTimeOver();

            if (timeOver)
            {
                Debug.Log("time over");
                game = false;
                timer.setTime(-1);
            }

            Debug.Log("Status - Blue: " + blueBar.inZone +
                      " | Green: " + greenBar.inZone +
                      " | Red: " + redBar.inZone +
                      " | Yellow: " + yellowBar.inZone);

            if (
                blueBar != null && blueBar.inZone &&
                greenBar != null && greenBar.inZone &&
                redBar != null && redBar.inZone &&
                yellowBar != null && yellowBar.inZone
            )
            {
                MainManager.Instance.setScore(MainManager.Instance.getScore() + 1);
                Debug.Log("score : " + MainManager.Instance.getScore());
                Debug.Log("should load new scene #########");
                SceneManager.LoadScene("Catch Uranium", LoadSceneMode.Single);
            }
        }
        else
        {
            if (lifeSystem != null && lifeSystem.timeLoss())
            {
                while (lifeCap < 1)
                {
                    lifeSystem.lives -= 1;
                    lifeSystem.changeLives();
                    Debug.Log("Lives: " + lifeSystem.lives);
                    lifeCap++;
                }
            }

            SceneManager.LoadScene("Catch Uranium", LoadSceneMode.Single);
        }
    }
}