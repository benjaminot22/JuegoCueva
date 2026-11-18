using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal3Script : MonoBehaviour
{
    public GameObject PanelFinal;
    void Start()
    {
        Time.timeScale = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            PanelFinal.SetActive (true);
        }
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }

}

