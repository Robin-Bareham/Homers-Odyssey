using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;


public class VMItem : MonoBehaviour
{
    public Sprite Beer;
    public Sprite Chips;
    public Sprite Donut;

    public VMHub VendingMachineHub;
    public GameObject ItemHolder1;
    public GameObject ItemHolder2;
    public GameObject ItemHolder3;
    public GameObject ItemHolder4;
    public GameObject ItemHolder5;
    public GameObject ItemHolder6;
    public GameObject ItemHolder7;
    public GameObject ItemHolder8;
    public GameObject ItemHolder9;

    private GameObject[] Items;

    private int AnswerDigits;
    private int DonutPositon;
    private int RandomItemImage;


    // Start is called before the first frame update
    void Start()
    {

        Items = new GameObject[] { ItemHolder1, ItemHolder2, ItemHolder3, ItemHolder4, ItemHolder5, ItemHolder6, ItemHolder7, ItemHolder8, ItemHolder9 };

        for(int i = 0; i < 9; i++)
        {
            RandomItem(Items[i]);
        }
        /*RandomItem(ItemHolder1);
        RandomItem(ItemHolder2);
        RandomItem(ItemHolder3);
        RandomItem(ItemHolder4);
        RandomItem(ItemHolder5);
        RandomItem(ItemHolder6);
        RandomItem(ItemHolder7);
        RandomItem(ItemHolder8);
        RandomItem(ItemHolder9); */

        System.Random RND = new System.Random();
        DonutPositon = RND.Next(0, 9);
        RandomDonut(Items[DonutPositon]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomItem(GameObject ItemHolder)
    {

        SpriteRenderer sr = ItemHolder.GetComponent<SpriteRenderer>();

        System.Random RND = new System.Random();
        RandomItemImage = RND.Next(1, 3);

        switch (RandomItemImage)
        {
            case 1: //1st is beer
                sr.sprite = Beer;
                ItemHolder.transform.localScale = new Vector3(0.05f, 0.05f, 1f);
                break;
            case 2: //Second option is chips
                sr.sprite = Chips;
                ItemHolder.transform.localScale = new Vector3(0.05f, 0.05f, 1f);
                break;
            default: 
                Debug.LogWarning("Error converting sprite image.");
                break;
        }
    }

    public void RandomDonut(GameObject ChosenItem)
    {
        Debug.Log("Donut Positon: " + (DonutPositon+1));
        SpriteRenderer sr = ChosenItem.GetComponent<SpriteRenderer>();
        sr.sprite = Donut;
        ChosenItem.transform.localScale = new Vector3(0.2f, 0.2f, 1f);
    }

 
}
