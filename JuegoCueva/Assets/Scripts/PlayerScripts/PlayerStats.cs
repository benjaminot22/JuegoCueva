using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{ 
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
        currentHealth -= damage;
        Debug.Log("Jugador atacado! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("El jugador ha muerto!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    public void TakeGems(int gems)
    {
        currentgems += gems;
        Debug.Log("Gemas conseguidas: " + currentgems);

    }
}

