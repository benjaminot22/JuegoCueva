using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void ReinicioNivel()
    {
        Time.timeScale = 1f;
       
        if (GameManager.instance != null)
        {
            GameManager.instance.ReiniciarEstadisticas();
        }
        else
        {
            Time.timeScale = 1f;
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnEnable()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.BuscarPanel();
        }
    }
}
