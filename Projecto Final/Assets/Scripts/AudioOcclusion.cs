using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioOcclusion : MonoBehaviour
{
    public float maxDistance = 10f; // Maximum distance at which occlusion starts
    public LayerMask occlusionMask; // Layer mask for objects that can occlude sound

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        RaycastHit hit;
        Vector3 listenerPosition = Camera.main.transform.position; // Or another listener position

        // Cast a ray from the audio source to the listener
        if (Physics.Raycast(transform.position, listenerPosition - transform.position, out hit, maxDistance, occlusionMask))
        {
            // If ray hits an object, reduce the volume based on distance
            float distance = Vector3.Distance(transform.position, listenerPosition);
            float attenuation = Mathf.Clamp01(1 - (distance / maxDistance));
            audioSource.volume = attenuation;
        }
        else
        {
            // If no obstacle, play audio at full volume
            audioSource.volume = 4f;
        }
    }
}
