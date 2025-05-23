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
    public VMHub VendingMachineHub;
    public TextMeshProUGUI DisplayText;
    

    public void DoThing() //Ignore this
    {
        Debug.Log("HELLO");
        Console.WriteLine("Did one thing");
    }

    public void DoAnother() //Ignore this
    {
        Debug.Log("GOODBYE");
        Console.WriteLine("Did another thing");
    }

    public void NumberInput() //Runs the subroutine if the vending machine button is a number
    {
        string ObjectName = gameObject.name.ToString(); //Get's the Button's name
        char ButtonChar = ObjectName.ToCharArray()[ObjectName.Length - 1]; //Converts the last name of the button's name into a character
        int ButtonNumb= ButtonChar - '0'; //Then into an int

        Debug.Log(ButtonNumb); 

        if (DisplayText.text.Length < 4) //Caps max display number at 4 digits (Subject to change later)
        {
            DisplayText.text += ButtonNumb.ToString(); //Converts then adds the digit to the Display panel on the vending machine
        }

    }

    public void Clear() //Self explanatory
    {
        DisplayText.text = "";
        
    }

    public void Enter() //Self explanatory
    {
        int digits = Convert.ToInt32(DisplayText.text); //Converts it to int
        VendingMachineHub.PressedEnter(digits); //Sends it to the VMHub

    }

   

}
