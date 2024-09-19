using UnityEngine;

public class CapsuleCollision : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the other object has a specific tag or is of a certain type
        if (collision.gameObject.CompareTag("Capsule"))
        {
            // Play the audio clip
            audioSource.Play();
        }
    }
}
