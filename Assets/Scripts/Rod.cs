using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rod : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -7f) 
        {
            Destroy(gameObject);
            //Stop minigame and lose life
            //SceneManager.LoadScene("LoseLife");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
