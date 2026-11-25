using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    public GameObject[] Vidas;
    public TextMeshProUGUI textoMonedas;
    public int vidas = 3;
    public GameObject PanelGameOver;


    private void Start()
    {
        {
            PanelGameOver.SetActive(false);
        }
    }
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
