using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LifeSystem : MonoBehaviour
{
    public GameObject hearts;
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Image heart_gone1;
    public Image heart_gone2;
    public Image heart_gone3;

    // Start is called before the first frame update
    void Start()
    {
        heart1.enabled = true;
        heart2.enabled = true;
        heart3.enabled = true;
        heart_gone1.enabled = false;
        heart_gone2.enabled = false;
        heart_gone3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void changeLives(int current_lives) 
    {
        if (current_lives == 1)
        {
            heart1.enabled = false;
            heart_gone1.enabled = true;
            //end the whole game
        }
        else if (current_lives == 2)
        {
            heart2.enabled = false;
            heart_gone2.enabled = true;
        }
        else if (current_lives == 3)
        {
            heart3.enabled = false;
            heart_gone3.enabled = true;

        }
    }
}
