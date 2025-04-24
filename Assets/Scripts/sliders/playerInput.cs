using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SocialPlatforms.Impl;

public class playerInput : MonoBehaviour
{

    public float moveSpeed;

    public Rigidbody2D blueSlider;
    public Rigidbody2D greenSlider;
    public Rigidbody2D redSlider;
    public Rigidbody2D yellowSlider;

    
    private Vector2 mousePosition;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0f;

           RaycastHit2D hit = Physics2D.Raycast(mouseWorldPosition, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Clicked on: " + hit.collider.gameObject.name + " Tag: " + hit.collider.tag);
                
                if (hit.collider.CompareTag("blue bar"))
                {
                    blueSlider.MovePosition(new Vector2(blueSlider.position.x, mouseWorldPosition.y));
                }
                
                else if (hit.collider.CompareTag("green bar"))
                {
                    greenSlider.MovePosition(new Vector2(greenSlider.position.x, mouseWorldPosition.y));
                }

                else if (hit.collider.CompareTag("red bar"))
                {
                    redSlider.MovePosition(new Vector2(redSlider.position.x, mouseWorldPosition.y));
                }

                else if (hit.collider.CompareTag("yellow bar"))
                {
                    yellowSlider.MovePosition(new Vector2(yellowSlider.position.x, mouseWorldPosition.y));
                }

    }


            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "guide")
        {
            
        
            
            
        }
    }
}
