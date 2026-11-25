using UnityEngine;

public class GemScript : MonoBehaviour
{
    [SerializeField] private int gems = 5;
    public int valorPuntos = 1;
    public int valorgema = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("Gema recolectada!");

            PlayerStats playerCoins = collision.GetComponent<PlayerStats>();
            {
                playerCoins.TakeGems(gems);
            }

            GameManager.instance.SumarGema(valorgema);

            Destroy(gameObject);
        }
    }

}

