using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
   public TextMeshProUGUI textoVidas;
   public TextMeshProUGUI textoMonedas;

   void Update()
   {
        if(GameManager.instance != null)
        {
            textoVidas.text = "Vidas: " + GameManager.instance.vidas;
            textoMonedas.text = "Gemas: " + GameManager.instance.puntos;
        }
   }
}
