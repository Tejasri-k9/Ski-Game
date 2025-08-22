using UnityEngine;

public class HurdlePass : MonoBehaviour
{
    public static int score = 0; // Keeps track of score

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player crosses the gate
        {
            score++; // Increase score
            Debug.Log("Passed a hurdle! Score: " + score);
            Destroy(gameObject, 2f); // Remove hurdle after passing (optional)
        }
    }
}

