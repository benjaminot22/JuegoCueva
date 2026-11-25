using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZoneScript : MonoBehaviour
{
    public GameObject PanelGameOver;

    private void Start()
    {
        Time.timeScale = 1F;
        PanelGameOver.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            Time.timeScale = 0F;
            PanelGameOver.SetActive(true);
        }
    }
}
