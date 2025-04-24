using UnityEngine;

public class greenGuideDetection : MonoBehaviour
{
    public GameObject greenGuide;
    public bool inZone = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == greenGuide)
        {
            Debug.Log("green slider entered its guide zone!");
            inZone = true;
        }
    }

    

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == greenGuide)
        {
            Debug.Log("green slider exited its guide zone.");
            inZone = false;
        }
    }
}