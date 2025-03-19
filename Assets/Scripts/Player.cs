using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{

    public float moveSpeed;
    Rigidbody2D rb;
    public TextMeshProUGUI score_text;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score_text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            //Snaps to mouse pos
            rb.MovePosition(touchPos);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Rod")
        {
            score++;
            score_text.text = score.ToString();
        }
    }
}
