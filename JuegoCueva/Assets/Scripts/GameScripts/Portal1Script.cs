using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal1Script : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
