using UnityEngine;

public class RockScript : MonoBehaviour
{
    [SerializeField] private int damage = 15;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player") == true)
        {
            collision.gameObject.GetComponent<PlayerStats>().TakeDamage(15);
        }
    }

}
