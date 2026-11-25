using UnityEngine;

public class Gemas : MonoBehaviour
{
    public int valorPuntos = 1;
    public int valorgema = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.SumarGema(valorgema);
            Destroy(gameObject);
        }
    }
}
