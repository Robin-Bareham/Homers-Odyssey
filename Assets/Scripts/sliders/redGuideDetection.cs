using UnityEngine;

public class redGuideDetection : MonoBehaviour
{
    public GameObject redGuide;
    public bool inZone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == redGuide)
        {
            Debug.Log("Red slider entered its guide zone!");
            inZone = true;
        }
    }

   

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == redGuide)
        {
            Debug.Log("Red slider exited its guide zone.");
            inZone = false;
        }
    }
}