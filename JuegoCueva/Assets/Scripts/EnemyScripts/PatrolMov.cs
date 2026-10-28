using UnityEngine;

public class PatrolMov : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    public float velocidad = 2f;
    private int direccion = -1;


    void Update()
    {

        transform.Translate(new Vector2(direccion * velocidad * Time.deltaTime, 0));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player") == false)
        {

            direccion = direccion * -1;
            if (direccion > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (direccion < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        else
        {
            collision.gameObject.GetComponent<PlayerStats>().TakeDamage(10);
        }




    }
}
