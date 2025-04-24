using UnityEngine;

public class yellowGuideDetection : MonoBehaviour
{

    
    public GameObject yellowGuide;
    public bool inZone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == yellowGuide)
        {
            Debug.Log("yellow slider entered its guide zone!");
            inZone = true;
            
        }
    }

    

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == yellowGuide)
        {
            Debug.Log("yellow slider exited its guide zone.");
            inZone = false;
        }
    }
}