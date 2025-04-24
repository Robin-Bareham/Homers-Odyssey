using UnityEngine;



public class blueGuideDetection : MonoBehaviour
{
    
    
    
    public GameObject blueGuide;
    public bool inZone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == blueGuide)
        {
            Debug.Log("Blue slider entered its guide zone!");
            inZone = true;
            
            
        }
    }

   

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == blueGuide)
        {
            Debug.Log("Blue slider exited its guide zone.");
           inZone = false;
        }
    }
}