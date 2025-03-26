using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rod : MonoBehaviour
{
    private bool failed = false;
    public GameManager gameManager;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (gameManager.getMinigameOver()) 
        { Destroy(gameObject); }
        if(transform.position.y < -7f) 
        {
            Destroy(gameObject);
            failed = true;
            gameManager.setMinigameFailed(true); //Alerts GameManager minigame has failed
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject); //Destroys rods on contact

            //Another potential spot to add sound file of rods being collected
        }
    }

    public bool getFailed() {  return failed; }
}
