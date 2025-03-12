using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{

    public float moveSpeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            //Snaps to mouse pos
            rb.MovePosition(touchPos);
            
            //Gradually moves to mouse pos
            
            //if (touchPos.x < 0)
            //{

            //  rb.AddForce(Vector2.left * moveSpeed);            
            //}
            //else
            //{
            //    rb.AddForce(Vector2.right * moveSpeed);
            //}
        }
        
    }
}
