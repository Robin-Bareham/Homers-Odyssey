using UnityEngine;

public class BlueGuideDetection : MonoBehaviour
{
    public GameObject blueGuide;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == blueGuide)
        {
            Debug.Log("Blue slider entered its guide zone!");
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == blueGuide)
        {
            Debug.Log("Blue slider is staying inside its guide zone.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == blueGuide)
        {
            Debug.Log("Blue slider exited its guide zone.");
        }
    }
}