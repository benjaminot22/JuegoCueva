using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioClip GemSound;
    [SerializeField] private AudioClip HitSound;
    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayGemSound()
    {
        if (GemSound != null)
        {
            audioSource.PlayOneShot(GemSound);
        }
    }

    public void PlayHitSound()
    {
        if (GemSound != null)
        {
            audioSource.PlayOneShot(HitSound);
        }
    }

}
