using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScreenScript : MonoBehaviour
{
    public GameObject PantallaFinal;

    private void Start()
    {
        PantallaFinal.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PantallaFinal.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ReiniciarDesdeNivel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
        
}
