using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int puntos = 0;
    public int vidas = 3;

    [Header("UI Game Over")]
    public GameObject panelGameOver;

    void Star()
    {
        BuscarPanel();
    }

    public void BuscarPanel()
    {
        if (panelGameOver == null)
        {
            panelGameOver = GameObject.Find("Panel");
        }
        
        if (panelGameOver != null)
        {
            panelGameOver.SetActive(false);
        }
    }

    public void RestarVidas(int cantidad)
    {
        Debug.Log("Vidas restantes: " + vidas);
        
        vidas -= cantidad;

        if (vidas <0)
        {
            vidas = 0;
            Debug.Log("Game Over");

            if (panelGameOver == null)
            {
                panelGameOver = GameObject.Find("Panel");
            }

            if (panelGameOver != null)
            {
                panelGameOver.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        Debug.Log("Puntos actuales: " + puntos);
    }

    public void ReiniciarEstadisticas()
    {
        vidas = 3;
        puntos = 0;
        Time.timeScale = 1f;
    }
}
