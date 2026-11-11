using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaMuerta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Player"))
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.vidas = 3;
                GameManager.instance.puntos = 0;
            }
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}