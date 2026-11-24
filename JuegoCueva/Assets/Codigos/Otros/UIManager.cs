using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject[] Vidas;
    public TextMeshProUGUI textoMonedas;
    public int vidas = 3;

    void Update()
    {
        if (GameManager.instance != null)
        {
            textoMonedas.text = "" + GameManager.instance.puntos;
        }
    }

    public void DesactivarVida(int indice)
    {
        Vidas[indice].SetActive(false);
    }



    public void ActivarVida(int indice)
    {
        Vidas[indice].SetActive(true);
    }

    public void PerderVida()
    {
        vidas -= 1;
        DesactivarVida(vidas);
    }
}
