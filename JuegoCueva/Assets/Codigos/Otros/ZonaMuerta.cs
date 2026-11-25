using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaMuerta : MonoBehaviour
{
    public GameObject PanelGameOver;
    private void Start()
    {
        Time.timeScale = 1F;
        PanelGameOver.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Player"))
        {
            Time.timeScale = 0F;
            PanelGameOver.SetActive(true);
        }
    }
}