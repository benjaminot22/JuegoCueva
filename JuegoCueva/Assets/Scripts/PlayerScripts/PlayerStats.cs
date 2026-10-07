using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoDamage;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int startGems = 0;
    private int currentHealth;
    public int currentgems;

    void Start()
    {
        currentHealth = maxHealth;
        currentgems = startGems;
    }

    public void TakeDamage(int damage)
    {
        sfxSource.PlayOneShot(sonidoDamage);
        currentHealth -= damage;
        Debug.Log("Jugador atacado! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("El jugador ha muerto!");
            // gameObject.SetActive(false);
        }
    }

    public void TakeGems(int gems)
    {
        currentgems += gems;
        Debug.Log("Gemas conseguidas: " + currentgems);

    }
}

