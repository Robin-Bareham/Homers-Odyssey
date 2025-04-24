using UnityEngine;

public class yellowGuideDetection : MonoBehaviour
{
    public GameObject yellowGuide;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == yellowGuide)
        {
            Debug.Log("yellow slider entered its guide zone!");
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == yellowGuide)
        {
            Debug.Log("yellow slider is staying inside its guide zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == yellowGuide)
        {
            Debug.Log("yellow slider exited its guide zone.");
        }
    }
}