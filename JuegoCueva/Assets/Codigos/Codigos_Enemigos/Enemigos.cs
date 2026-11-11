using System.Collections;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public float velocidad = 2f;
    public float distanciaMov = 3f;
    public int damage = 1;
    private Vector3 posicionInicial;
    private bool movDerecha = true;
    private SpriteRenderer sR;

    public ParticleSystem PolvoCaminar;
    private bool puedeDanar = true;

    void Start()
    {
        posicionInicial = transform.position;
        sR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (movDerecha)
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
            if (transform.position.x >= posicionInicial.x + distanciaMov)
            {
                movDerecha = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
            if (transform.position.x <= posicionInicial.x - distanciaMov)
            {
                movDerecha = true;
            }
        }

        if (PolvoCaminar != null && !PolvoCaminar.isPlaying)
        {
            PolvoCaminar.Play();
        }

        if (sR != null)
        {
            sR.flipX = !movDerecha;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && puedeDanar)
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.RestarVidas(damage);
                StartCoroutine(TiempoEsperaDano());
            }
        }
    }

    private IEnumerator TiempoEsperaDano()
    {
        puedeDanar = false;
        yield return new WaitForSeconds(1f); // Tiempo de espera antes de volver a infligir daño
        puedeDanar = true;
    }
}