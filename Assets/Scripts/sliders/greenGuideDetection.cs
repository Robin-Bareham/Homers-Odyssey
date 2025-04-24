using UnityEngine;

public class greenGuideDetection : MonoBehaviour
{
    public GameObject greenGuide;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == greenGuide)
        {
            Debug.Log("green slider entered its guide zone!");
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == greenGuide)
        {
            Debug.Log("green slider is staying inside its guide zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == greenGuide)
        {
            Debug.Log("green slider exited its guide zone.");
        }
    }
}