using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIManager uimanager;
    public int puntos;
    public int vidas = 3;
    public GameObject PanelGameOver;

    [Header("Gemas")]
    public int gemas = 0;
    public TextMeshProUGUI textogemas;

    [Header("UI Game Over")]
    public GameObject panelGameOver;

    public object GemasTotales { get; internal set; }

    private void Start()
    {
        Time.timeScale = 1f;
        if (uimanager == null)
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

    void start()
    {
        CargarMonedas();
        ActualizarMonedasUI();

    }

    public void SumarGema(int cantidad)
    {
        gemas += cantidad;
        ActualizarMonedasUI();
        GuardarMonedas();
    }

    void ActualizarMonedasUI()
    {
        if (textogemas != null)
            textogemas.text = "x" + gemas.ToString();
    }

    void GuardarMonedas()
    {
        PlayerPrefs.SetInt("Gemas", gemas);
        PlayerPrefs.Save();
    }

    void CargarMonedas()
    {
        gemas = PlayerPrefs.GetInt("Gemas", 0);
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

        if (vidas <= 0)
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

    public void PerderVida()
    {
        if (vidas <= 1)
        {
            Time.timeScale = 0f;
            PanelGameOver.SetActive(true);
        }
        vidas -= 1;
        uimanager.DesactivarVida(vidas);

    }


}
