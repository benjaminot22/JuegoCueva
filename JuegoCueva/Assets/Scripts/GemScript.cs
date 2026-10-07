using UnityEngine;

public class GemScript : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoGema;

    [SerializeField] private int gems = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sfxSource.PlayOneShot(sonidoGema);
            print("Gema recolectada!");

            PlayerStats playerCoins = collision.GetComponent<PlayerStats>();
            {
                playerCoins.TakeGems(gems);
            }
            Destroy(gameObject);
        }
    }

}

