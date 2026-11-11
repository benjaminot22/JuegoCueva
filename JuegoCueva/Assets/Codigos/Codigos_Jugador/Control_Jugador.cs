using UnityEngine;

public class Control_Jugador : MonoBehaviour
{
  public float velocidad = 5f;
  public float fuerzaSalto = 7f;
  private Rigidbody2D rb;
  private bool enSuelo = false;

  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    float movimientoX = Input.GetAxis("Horizontal");
    rb.linearVelocity = new Vector2(movimientoX * velocidad, rb.linearVelocity.y);
    
    if (Input.GetButtonDown("Jump") && enSuelo)
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        enSuelo = false;
    }
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Suelo"))
    {
        enSuelo = true;
    }
  }
}