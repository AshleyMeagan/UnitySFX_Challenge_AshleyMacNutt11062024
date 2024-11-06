using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering is the player (using tag or layer check)
        if (other.CompareTag("Player"))
        {
            // Play the audio if it’s not already playing
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object exiting is the player
        if (other.CompareTag("Player"))
        {
            // Stop the audio when leaving the trigger
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
