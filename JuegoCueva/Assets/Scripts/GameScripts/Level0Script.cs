using UnityEngine;
using UnityEngine.SceneManagement;

public class Level0Script : MonoBehaviour
{
    public void IniciarJuego()
    {
        SceneManager.LoadScene("Level1");
    }
    public void SalirDelJuego()
    {
        Application.Quit();
    }
}
