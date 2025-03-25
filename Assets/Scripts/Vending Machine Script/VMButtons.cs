using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class VMButtons : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    public TextMeshProUGUI DisplayText;

    public void DoThing()
    {
        Debug.Log("HELLO");
        Console.WriteLine("Did one thing");
    }

    public void DoAnother()
    {
        Debug.Log("GOODBYE");
        Console.WriteLine("Did another thing");
    }

    public void NumberInput()
    {
        string ObjectName = gameObject.name.ToString(); //Get's the Button's name
        char ButtonChar = ObjectName.ToCharArray()[ObjectName.Length - 1]; //Converts the last name of the button name it into a character
        int ButtonNumb= ButtonChar - '0'; //Then into an int

        Debug.Log(ButtonNumb);

        if (DisplayText.text.Length < 4) //Caps it at 4 digits (Subject to change later)
        {
            DisplayText.text += ButtonNumb.ToString(); //Converts then adds the digit to the DisplayText
        }

    }

    public void Clear()
    {

        DisplayText.text = "";
    }

    public void Enter()
    {
        string TheRightCode="";

        if (DisplayText.text.Equals(TheRightCode)) //Wins the minigame!
        {
            Debug.Log("Vending machine minigame won!");
        }
        else //Loses the minigame!
        {
            Debug.Log("Vending machine minigame failed!");
        }

    }

}
