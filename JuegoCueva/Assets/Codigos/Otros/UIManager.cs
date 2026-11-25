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
            textoMonedas.text = "X" + GameManager.instance.puntos;
        }
       

    }


    public void DesactivarVida(int indice)
    {
        Vidas[indice].SetActive(false);

    }

    
}
