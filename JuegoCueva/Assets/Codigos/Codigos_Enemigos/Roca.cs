using UnityEngine;

public class Roca : MonoBehaviour
{
    public int damage = 1;
    
    private void OnCollisionEnter2D(Collision2D collision)   
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            if (GameManager.instance != null) 
            { 
                GameManager.instance.RestarVidas(damage); 
            }
        }
    }
}
