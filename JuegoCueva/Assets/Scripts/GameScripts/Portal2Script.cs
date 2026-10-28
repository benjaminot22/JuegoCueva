using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal2Script : MonoBehaviour
{
    public GameObject Final;
    void Start()
    {
        Final.SetActive(false);
        Time.timeScale = 1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerMov>();
            Final.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ReiniciarNivel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
