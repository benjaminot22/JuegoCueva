using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal3Script : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
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

