using UnityEngine;

public class redGuideDetection : MonoBehaviour
{
    public GameObject redGuide;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == redGuide)
        {
            Debug.Log("Red slider entered its guide zone!");
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == redGuide)
        {
            Debug.Log("Red slider is staying inside its guide zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == redGuide)
        {
            Debug.Log("Red slider exited its guide zone.");
        }
    }
}