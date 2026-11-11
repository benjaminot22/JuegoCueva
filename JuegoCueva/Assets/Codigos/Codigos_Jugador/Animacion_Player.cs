using UnityEngine;

public class Animacion_Player : MonoBehaviour
{
    public float velocidadx = 5f;
    public float fuerzaSalto = 7f;
    public Transform detectorSuelo;
    public LayerMask capaSuelo;
    private bool estaEnSuelo;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sR;

    [Header("Efectos")]
    public ParticleSystem PolvoCaminar;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float movimientoX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimientoX * velocidadx, rb.linearVelocity.y);

        if (movimientoX > 0)
        {
            sR.flipX = false;
        }
        else if (movimientoX < 0)
        {
            sR.flipX = true;
        }

        estaEnSuelo = Physics2D.OverlapCircle(detectorSuelo.position, 0.2f, capaSuelo);

        if (Input.GetButtonDown("Jump") && estaEnSuelo)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        }

        anim.SetFloat("velocidadx", Mathf.Abs(movimientoX));
        anim.SetBool("enSuelo", estaEnSuelo);

        GestarParticulas(movimientoX);
    }

    void GestarParticulas(float movimientoX)
    {
        if(Mathf.Abs(movimientoX) > 0.1f)
        {
            if (!PolvoCaminar.isPlaying)
            {
                PolvoCaminar.Play();
            }
            
        }
        else
        {
            if (PolvoCaminar.isPlaying)
            {
                PolvoCaminar.Stop();
            }
        }
    }
}